namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a Windows service which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("0.1.5")>]
[<assembly: AssemblyFileVersionAttribute("0.1.5")>]
[<assembly: AssemblyMetadataAttribute("githash","0265fbf2d04a72f5c70c580953a7dbb822f385b6")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.5"
