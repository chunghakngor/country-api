
Basic ASP.NET Web API for Basic Country Data 

Requirements:
```
mongo
dotnet
```

To run:
```
cd country-api
dotnet build country-api.csproj
dotnet run country-api.csproj
```

To edit mongodb connection:
```
1. Open appsettings.json
2. Edit fields in COuntryDatabaseSettings
```

To edit host/port settings:
```
1. Open launchSettings.json
2. Edit applicationUrl under country_api
```

To access:
```
http://localhost:5000/api/country
https://localhost:5001/api/country
https://localhost:5001/swagger/index.html
```

Response example:
```
{
    id: "5f7d4c6716e25eeaf2aa83bf",
    countryCode: "NZ",
    name: "New Zealand",
    nationality: "New Zealander",
    capital: "Auckland",
    area: 268021,
    population: 4.886,
    gdp: 204.9
}
```
