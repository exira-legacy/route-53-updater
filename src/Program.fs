open FSharp.Configuration
open System
open System.Reflection
open System.IO
open Amazon
open Amazon.EC2.Util
open Amazon.Route53
open Amazon.Route53.Model
open Exira.ErrorHandling

let executablePath = Assembly.GetEntryAssembly().Location |> Path.GetDirectoryName
let configPath = Path.Combine(executablePath, "Updater.yaml")

type UpdaterConfig = YamlConfig<"Updater.yaml">
let updaterConfig = UpdaterConfig()
updaterConfig.Load configPath

type Errors =
    | FailedToRetrieveEc2MetaData of exn
    | FailedToRetrieveNetworkInterface
    | FailedToRetrieveRoute53Zone of exn
    | FailedToRetrieveRoute53ResourceRecordSet
    | FailedToRetrieveRoute53ResourceRecord
    | Route53ResourceRecordUpToDate
    | FailedToUpdateRoute53Zone of exn

let format errors =
    let formatError error =
        match error with
        | FailedToRetrieveEc2MetaData _ -> sprintf "Could not retrieve EC2 meta data."
        | FailedToRetrieveNetworkInterface -> sprintf "No network interfaces were found."
        | FailedToRetrieveRoute53Zone _ -> sprintf "Could not retrieve Route 53 zone."
        | FailedToRetrieveRoute53ResourceRecordSet -> sprintf "Route 53 Resource Record Set was not found."
        | FailedToRetrieveRoute53ResourceRecord -> sprintf "Route 53 Resource Record was not found."
        | Route53ResourceRecordUpToDate -> sprintf "Route 53 Resource Record is up to date!"
        | FailedToUpdateRoute53Zone _ -> sprintf "Could not update Route 53 zone."

    errors
    |> List.map formatError

let getNetworkInterfaces =
    try
        succeed EC2Metadata.NetworkInterfaces
    with
    | ex -> fail [FailedToRetrieveEc2MetaData ex]

let printNetworkInterfaces nics =
    let printDebug (nic: NetworkInterface) =
        printfn "Local: %A - Public: %A" nic.LocalHostname nic.PublicHostname

    if updaterConfig.Updater.Debug then nics |> Seq.iter printDebug
    else ()

let getNetworkInterface nics =
    let nic =
        nics
        |> Seq.toList
        |> Seq.tryHead

    match nic with
    | Some nic -> succeed nic
    | None -> fail [FailedToRetrieveNetworkInterface]

let getRoute53ResourceRecordSet =
    try
        use route53Client =
            new AmazonRoute53Client(
                updaterConfig.Updater.AwsAccessKey,
                updaterConfig.Updater.AwsSecretKey,
                RegionEndpoint.GetBySystemName updaterConfig.Updater.Region)

        let request =
            ListResourceRecordSetsRequest(
                HostedZoneId = updaterConfig.Updater.ZoneId,
                StartRecordName = updaterConfig.Updater.DomainName,
                StartRecordType = RRType.CNAME,
                MaxItems = string 1)

        let response = route53Client.ListResourceRecordSets request
        let resourceRecordSet =
            response.ResourceRecordSets
            |> Seq.tryHead

        let checkDomainName (resourceRecordSet: ResourceRecordSet) =
            match resourceRecordSet.Name, resourceRecordSet.Type with
            | n, t when n = updaterConfig.Updater.DomainName && t = RRType.CNAME -> succeed resourceRecordSet
            | _ -> fail [FailedToRetrieveRoute53ResourceRecordSet]

        match resourceRecordSet with
        | Some resourceRecordSet -> checkDomainName resourceRecordSet
        | None -> fail [FailedToRetrieveRoute53ResourceRecordSet]
    with
    | ex -> fail [FailedToRetrieveRoute53Zone ex]

let printResourceRecordSet resourceRecordSet =
    let printDebug (resourceRecordSet: ResourceRecordSet) =
        printfn "Name: %A - Type: %A" resourceRecordSet.Name resourceRecordSet.Type
        Seq.iter (fun (rr: ResourceRecord) -> printfn "RR: %s" rr.Value) resourceRecordSet.ResourceRecords

    if updaterConfig.Updater.Debug then resourceRecordSet |> printDebug
    else ()

let compareNicWithResourceRecordSet (nic: NetworkInterface) (resourceRecordSet: ResourceRecordSet) =
    let resourceRecord =
        resourceRecordSet.ResourceRecords
        |> Seq.tryHead

    match resourceRecord with
    | Some rr when rr.Value.StartsWith nic.PublicHostname -> fail [Route53ResourceRecordUpToDate]
    | None -> fail [FailedToRetrieveRoute53ResourceRecord]
    | Some rr ->
        rr.Value <- sprintf "%s." nic.PublicHostname
        succeed resourceRecordSet

let updateResourceRecordSet (resourceRecordSet: ResourceRecordSet) =
    try
        use route53Client =
            new AmazonRoute53Client(
                updaterConfig.Updater.AwsAccessKey,
                updaterConfig.Updater.AwsSecretKey,
                RegionEndpoint.GetBySystemName updaterConfig.Updater.Region)

        let changes = [ new Change(ChangeAction.UPSERT, resourceRecordSet) ]
        let changeBatch = ChangeBatch(Collections.Generic.List<Change>(changes))
        changeBatch.Comment <- sprintf "Updating CNAME to match real public hostname."
        let request = ChangeResourceRecordSetsRequest(updaterConfig.Updater.ZoneId, changeBatch)
        let response = route53Client.ChangeResourceRecordSets request

        succeed response
    with
    | ex -> fail [FailedToUpdateRoute53Zone ex]

[<EntryPoint>]
let main _ =
    let determineNic() =
        getNetworkInterfaces
        |> map (printNetworkInterfaces |> tee)
        |> bind getNetworkInterface

    let determineResourceRecordSet() =
        getRoute53ResourceRecordSet
        |> map (printResourceRecordSet |> tee)

    let determineNewResourceRecordSet =
        match determineNic(), determineResourceRecordSet() with
        | Success nic, Success resourceRecordSet -> compareNicWithResourceRecordSet nic resourceRecordSet
        | Failure a', Success _ -> fail a'
        | Success _ , Failure b' -> fail b'
        | Failure a', Failure b' -> fail (a' @ b')

    let route53Updater =
        determineNewResourceRecordSet
        |> map (printResourceRecordSet |> tee)
        |> bind updateResourceRecordSet

    match route53Updater with
    | Success result ->
        printfn "[%s] Route 53 Zone Updated!" result.ChangeInfo.Id
    | Failure errors ->
        let errorMessages = errors |> format
        printfn "%s" <| String.concat Environment.NewLine errorMessages

    0