namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a Windows service which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("0.1.6")>]
[<assembly: AssemblyFileVersionAttribute("0.1.6")>]
[<assembly: AssemblyMetadataAttribute("githash","ed0ede28330daa9f81af490eb703f5c84d89b3b4")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.6"
