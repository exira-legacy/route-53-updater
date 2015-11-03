namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a Windows service which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("0.1.3")>]
[<assembly: AssemblyFileVersionAttribute("0.1.3")>]
[<assembly: AssemblyMetadataAttribute("githash","8e6c8481c19594e5f74e70b79516a50724f598c0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.3"
