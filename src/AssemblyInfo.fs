namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.1.19")>]
[<assembly: AssemblyFileVersionAttribute("1.1.19")>]
[<assembly: AssemblyMetadataAttribute("githash","cdcbbc80cebb96338a948c94b434a941c310be8c")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.19"
