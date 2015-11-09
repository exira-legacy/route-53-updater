namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("0.1.8")>]
[<assembly: AssemblyFileVersionAttribute("0.1.8")>]
[<assembly: AssemblyMetadataAttribute("githash","9b1a1e9212bc54d8b3634915b2b3eda68d97014e")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.8"
