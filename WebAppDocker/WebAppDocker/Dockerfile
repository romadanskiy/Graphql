FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

COPY WebAppDocker/*.csproj ./WebAppDocker/

WORKDIR /app/WebAppDocker
RUN dotnet restore

WORKDIR /app

COPY WebAppDocker/ ./WebAppDocker/

WORKDIR /app/WebAppDocker
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0.9-focal-amd64 AS final
WORKDIR /app
COPY --from=build-env /app/WebAppDocker/out ./
ENTRYPOINT ["dotnet", "WebAppDocker.dll"]
