namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a Windows service which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("0.1.0")>]
[<assembly: AssemblyFileVersionAttribute("0.1.0")>]
[<assembly: AssemblyMetadataAttribute("githash","66c0ab78a56e99203f2a7a63d070d1a16e50ba89")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.0"
