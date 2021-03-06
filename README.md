
[![Logo](https://i.imgur.com/vdRK4wp.jpeg)](#)


# OpenWeatherMap.NET

C# API Wrapper for [OpenWeatherMap](https://openweathermap.org), written in C#

[![GitHub](https://img.shields.io/github/downloads/veeeleven/OpenWeatherMap.NET/total?color=%237BA1F7&logo=github&style=for-the-badge)](https://github.com/veeeleven/OpenWeatherMap.NET/releases/latest)
[![NuGet](https://img.shields.io/nuget/dt/OpenWeatherMapNet?color=%237BA1F7&logo=nuget&style=for-the-badge)](https://www.nuget.org/packages/OpenWeatherMapNet)
[![Latest](https://img.shields.io/github/v/tag/veeeleven/OpenWeatherMap.NET?color=%237BA1F7&label=RELEASE&logo=github&sort=semver&style=for-the-badge)](https://github.com/veeeleven/OpenWeatherMap.NET/releases/tag/1.0.0)
[![MIT](https://img.shields.io/github/license/veeeleven/OpenWeatherMap.NET?color=%237BA1F7&style=for-the-badge)](#).  
## Authors

- [@veeeleven](https://github.com/veeeleven)

  
## Usage/Example

```csharp
// Setup your API-KEY
OpenWeatherMapAPI api = new OpenWeatherMapAPI("API-KEY");
            
// Get Weather Location
var weather = await api.GetWeatherDataByCityName("Kon Tum");
            
// Output the Weather Data
Console.WriteLine(weather.Weather.FirstOrDefault().Description);
```

## Building

To Build This Project, run:

```bash
   nuget restore
   MSBuild.exe -property:Configuration=Release OpenWeatherMap.NET.csproj
```

## Features

- Lightweight
- Get Weather Data by city name
- Get Weather Data by CityID
- Get Weather Data by ZipCode
- Get Weather Data by longitude and latitude
- Get Weather Data from multiply cities within a rectangle zone
...


