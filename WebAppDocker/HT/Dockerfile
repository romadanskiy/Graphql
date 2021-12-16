FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

COPY HT/*.csproj ./HT/

WORKDIR /app/HT
RUN dotnet restore

WORKDIR /app

COPY HT/ ./HT/

WORKDIR /app/HT
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0.9-focal-amd64 AS final
WORKDIR /app
COPY --from=build-env /app/HT/out ./
ENTRYPOINT ["dotnet", "HT.dll"]
