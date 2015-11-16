# route-53-updater [![NuGet Status](http://img.shields.io/nuget/v/Exira.Route53Updater.svg?style=flat)](https://www.nuget.org/packages/Exira.Route53Updater/)

## Exira.Route53Updater

Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname.

### Usage

* Create a `Hosted Zone` in `Route 53` and write down the `Hosted Zone ID`
* Create a `Record Set` of type `CNAME` with for example `www` as name and a `TTL` of `60`

* Download the latest release from [the GitHub releases page](https://github.com/exira/route-53-updater/releases)
* Unzip on your `EC2 Instance`

* Edit `Updater.yaml` using:
  * AwsAccessKey: `YOUR AWS ACCESS KEY`, e.g.: `AXIURT98PXVXJU7K...`
  * AwsSecretKey: `YOUR AWS SECRET KEY`, e.g.: `1Y9poTREdb/8j1234Tr...`
  * Region: ```YOUR AWS REGION```, e.g.: ```eu-central-1`
  * ZoneId: `YOUR ZONE ID`, e.g.: `ZRTPOCDERLDCO`
  * DomainName: `YOUR DOMAIN`, e.g.: `www.example.org.` (Pay attention to the trailing .)

* Run `route-53-updater.exe`

* Your Route 53 record should now be updated with the public hostname of your EC2 instance

## Cloning

```git clone git@github.com:exira/route-53-updater.git -c core.autocrlf=input```

## Copyright

Copyright © 2015 Cumps Consulting BVBA / Exira and contributors.

## License

route-53-updater is licensed under [BSD (3-Clause)](http://choosealicense.com/licenses/bsd-3-clause/ "Read more about the BSD (3-Clause) License"). Refer to [LICENSE.txt](https://github.com/exira/route-53-updater/blob/master/LICENSE.txt) for more information.
