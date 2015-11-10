namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.1.11")>]
[<assembly: AssemblyFileVersionAttribute("1.1.11")>]
[<assembly: AssemblyMetadataAttribute("githash","a16e28c8e53195ef3cc9367c460e86920116f1e1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.11"
