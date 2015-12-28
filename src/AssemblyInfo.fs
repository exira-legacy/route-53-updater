namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("route-53-updater")>]
[<assembly: AssemblyProductAttribute("Exira.Route53Updater")>]
[<assembly: AssemblyDescriptionAttribute("Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname")>]
[<assembly: AssemblyVersionAttribute("1.1.20")>]
[<assembly: AssemblyFileVersionAttribute("1.1.20")>]
[<assembly: AssemblyMetadataAttribute("githash","44efaca452189fc04d0e2fa9d51329a898e9c66b")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.20"
