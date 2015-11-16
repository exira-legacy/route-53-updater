namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.1.14")>]
[<assembly: AssemblyFileVersionAttribute("1.1.14")>]
[<assembly: AssemblyMetadataAttribute("githash","f8277530c6515f81ff844ddfc83ba517b7edb152")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.14"
