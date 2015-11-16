(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
route-53-updater [![NuGet Status](http://img.shields.io/nuget/v/Exira.Route53Updater.svg?style=flat)](https://www.nuget.org/packages/Exira.Route53Updater/)
======================

Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname.

### Usage

 * Create a `Hosted Zone` in `Route 53` and write down the `Hosted Zone ID`
 * Create a `Record Set` of type `CNAME` with for example `www` as name and a `TTL` of `60`

 * Download the latest release from [the GitHub releases page](https://github.com/exira/route-53-updater/releases)
 * Unzip on your `EC2 Instance`

 * Edit `Updater.yaml` using:
   * AwsAccessKey: `YOUR AWS ACCESS KEY`, e.g.: `AXIURT98PXVXJU7K...`
   * AwsSecretKey: `YOUR AWS SECRET KEY`, e.g.: `1Y9poTREdb/8j1234Tr...`
   * Region: `YOUR AWS REGION`, e.g.: `eu-central-1`
   * ZoneId: `YOUR ZONE ID`, e.g.: `ZRTPOCDERLDCO`
   * DomainName: `YOUR DOMAIN`, e.g.: `www.example.org.` (Pay attention to the trailing `.`)

 * Run `route-53-updater.exe`

 * Your `Route 53` record should now be updated with the public hostname of your EC2 instance

### Cloning

`git clone git@github.com:exira/route-53-updater.git -c core.autocrlf=input`

### Contributing and copyright

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork
the project and submit pull requests. You might also want to read the
[library design notes][readme] to understand how it works.

For more information see the [License file][license] in the GitHub repository.

  [content]: https://github.com/exira/route-53-updater/tree/master/docs/content
  [gh]: https://github.com/exira/route-53-updater
  [issues]: https://github.com/exira/route-53-updater/issues
  [readme]: https://github.com/exira/route-53-updater/blob/master/README.md
  [license]: https://github.com/exira/route-53-updater/blob/master/LICENSE.txt
*)
