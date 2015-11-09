namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a Windows service which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("0.1.7")>]
[<assembly: AssemblyFileVersionAttribute("0.1.7")>]
[<assembly: AssemblyMetadataAttribute("githash","c9938b2948a0b037de13de620b312bc7edd1704a")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.7"
