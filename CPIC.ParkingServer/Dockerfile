#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CPIC.ParkingServer/CPIC.ParkingServer.csproj", "CPIC.ParkingServer/"]
RUN dotnet restore "CPIC.ParkingServer/CPIC.ParkingServer.csproj"
COPY . .
WORKDIR "/src/CPIC.ParkingServer"
RUN dotnet build "CPIC.ParkingServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CPIC.ParkingServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CPIC.ParkingServer.dll"]