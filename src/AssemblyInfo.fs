namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.1.13")>]
[<assembly: AssemblyFileVersionAttribute("1.1.13")>]
[<assembly: AssemblyMetadataAttribute("githash","05ee9a1cae6e66c3855d2be2d4a0e3133046de27")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.13"
