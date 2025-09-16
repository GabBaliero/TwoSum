FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY TwoSum.sln .

COPY TwoSum/TwoSum.csproj ./TwoSum/

RUN dotnet restore

COPY TwoSum/. ./TwoSum/

WORKDIR /app/TwoSum
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "TwoSum.dll"]
