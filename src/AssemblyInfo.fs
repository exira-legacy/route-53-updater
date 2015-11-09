namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.0.10")>]
[<assembly: AssemblyFileVersionAttribute("1.0.10")>]
[<assembly: AssemblyMetadataAttribute("githash","4c6f67740f6f3d2f507338581055c0bc49d45e42")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.10"
