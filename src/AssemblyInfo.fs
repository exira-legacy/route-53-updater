namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a Windows service which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("0.1.2")>]
[<assembly: AssemblyFileVersionAttribute("0.1.2")>]
[<assembly: AssemblyMetadataAttribute("githash","0b7cb9acaf694c879695a8ec7ba96c1c8d2af671")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.2"
