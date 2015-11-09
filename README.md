# route-53-updater [![NuGet Status](http://img.shields.io/nuget/v/Exira.Route53Updater.svg?style=flat)](https://www.nuget.org/packages/Exira.Route53Updater/)

## Exira.Route53Updater

Exira.Route53Updater is a console application which updates a Route 53 record with the current EC2 hostname.

### Usage

 * Edit ```Updater.yaml``` using:
   * AwsAccessKey: ```YOUR AWS ACCESS KEY```, e.g.: ```AXIURT98PXVXJU7K...```
   * AwsSecretKey: ```YOUR AWS SECRET KEY```, e.g.: ```1Y9poTREdb/8j1234Tr...```
   * Region: ```YOUR AWS REGION```, e.g.: ```eu-central-1```
   * ZoneId: ```YOUR ZONE ID```, e.g.: ```ZRTPOCDERLDCO```
   * DomainName: ```YOUR DOMAIN```, e.g.: ```www.example.org.```

 * Run ```route-53-updater.exe```

## Cloning

```git clone git@github.com:exira/route-53-updater.git -c core.autocrlf=input```
