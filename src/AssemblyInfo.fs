namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a Windows service which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("0.1.4")>]
[<assembly: AssemblyFileVersionAttribute("0.1.4")>]
[<assembly: AssemblyMetadataAttribute("githash","c719dce235e943eff146eb6f48de1e6247da60b8")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.4"
