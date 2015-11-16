namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.1.16")>]
[<assembly: AssemblyFileVersionAttribute("1.1.16")>]
[<assembly: AssemblyMetadataAttribute("githash","6454d19447616aa6f8de4d5ae36e8cc93991f663")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.16"
