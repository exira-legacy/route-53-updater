open FSharp.Configuration
open Amazon.EC2.Util
open Exira.ErrorHandling
open System

type UpdaterConfig = YamlConfig<"Updater.yaml">
let updaterConfig = UpdaterConfig()

type Errors =
    | FailedToRetrieveEc2MetaData of exn
    | FailedToRetrieveNetworkInterface

let format errors =
    let formatError error =
        match error with
        | FailedToRetrieveEc2MetaData _ -> sprintf "Could not retrieve EC2 meta data."
        | FailedToRetrieveNetworkInterface -> sprintf "No network interfaces were found."

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
    nics

let getNetworkInterface nics =
    let nic =
        nics
        |> Seq.toList
        |> Seq.tryHead

    match nic with
    | Some nic -> succeed nic
    | None -> fail [FailedToRetrieveNetworkInterface]

[<EntryPoint>]
let main argv =
    let route53Updater =
        getNetworkInterfaces
        |> map printNetworkInterfaces
        |> bind getNetworkInterface

        // TODO: Go to route 53 and update if not the same

    match route53Updater with
    | Success _ -> printfn "Updated"
    | Failure errors ->
        let errorMessages = errors |> format
        printfn "%s" <| String.concat Environment.NewLine errorMessages

    0
