namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.1.15")>]
[<assembly: AssemblyFileVersionAttribute("1.1.15")>]
[<assembly: AssemblyMetadataAttribute("githash","5807a34df81be5518f3846b702de2b734135b082")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.15"
