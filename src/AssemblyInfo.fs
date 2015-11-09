namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.0.9")>]
[<assembly: AssemblyFileVersionAttribute("1.0.9")>]
[<assembly: AssemblyMetadataAttribute("githash","08ecca4664295f289a303d90b7992b9b0678df73")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.9"
