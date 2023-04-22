#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["RPG.SheetGenerator/RPG.SheetGenerator.API.csproj", "RPG.SheetGenerator/"]
COPY ["RPG.SheetGenerator.Application/RPG.SheetGenerator.Application.csproj", "RPG.SheetGenerator.Application/"]
COPY ["RPG.SheetGenerator.Core/RPG.SheetGenerator.Core.csproj", "RPG.SheetGenerator.Core/"]
COPY ["RPG.SheetGenerator.Infrastructure/RPG.SheetGenerator.Infrastructure.csproj", "RPG.SheetGenerator.Infrastructure/"]
RUN dotnet restore "RPG.SheetGenerator/RPG.SheetGenerator.API.csproj"
COPY . .
WORKDIR "/src/RPG.SheetGenerator"
RUN dotnet build "RPG.SheetGenerator.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RPG.SheetGenerator.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RPG.SheetGenerator.API.dll"]