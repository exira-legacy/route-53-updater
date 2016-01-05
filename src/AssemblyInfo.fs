namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.2.23")>]
[<assembly: AssemblyFileVersionAttribute("1.2.23")>]
[<assembly: AssemblyMetadataAttribute("githash","27d729d3813713bcf40d3a73b2473e4d1b690f51")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.2.23"
