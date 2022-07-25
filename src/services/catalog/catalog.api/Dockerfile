#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["services/catalog/catalog.api/catalog.api.csproj", "services/catalog/catalog.api/"]
RUN dotnet restore "services/catalog/catalog.api/catalog.api.csproj"
COPY . .
WORKDIR "/src/services/catalog/catalog.api"
RUN dotnet build "catalog.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "catalog.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "catalog.api.dll"]