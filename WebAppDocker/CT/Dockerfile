FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

COPY CT/*.csproj ./CT/

WORKDIR /app/CT
RUN dotnet restore

WORKDIR /app

COPY CT/ ./CT/

WORKDIR /app/CT
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0.9-focal-amd64 AS final
WORKDIR /app
COPY --from=build-env /app/CT/out ./
ENTRYPOINT ["dotnet", "CT.dll"]
