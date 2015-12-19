namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.1.18")>]
[<assembly: AssemblyFileVersionAttribute("1.1.18")>]
[<assembly: AssemblyMetadataAttribute("githash","dbe81eb017d1b118d26052feb59e801e33d88ae7")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.18"
