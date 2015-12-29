namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.2.22")>]
[<assembly: AssemblyFileVersionAttribute("1.2.22")>]
[<assembly: AssemblyMetadataAttribute("githash","02258bd0e6e59b9b2309fb74061366e67649055a")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.2.22"
