FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HT/HT.csproj", "HT/"]
RUN dotnet restore "HT/HT.csproj"
COPY . .
WORKDIR "/src/HT"
RUN dotnet build "HT.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HT.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HT.dll"]
