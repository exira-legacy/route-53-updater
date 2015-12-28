namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.1.21")>]
[<assembly: AssemblyFileVersionAttribute("1.1.21")>]
[<assembly: AssemblyMetadataAttribute("githash","1d207752469fc15626b22ebf40b768aea278f887")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.21"
