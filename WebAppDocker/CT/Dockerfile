FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CT/CT.csproj", "CT/"]
RUN dotnet restore "CT/CT.csproj"
COPY . .
WORKDIR "/src/CT"
RUN dotnet build "CT.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CT.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CT.dll"]
