namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.1.17")>]
[<assembly: AssemblyFileVersionAttribute("1.1.17")>]
[<assembly: AssemblyMetadataAttribute("githash","abf2c2ebd4df7f582ed940bd44b2897887fc6fed")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.17"
