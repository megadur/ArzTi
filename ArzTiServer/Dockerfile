#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ArzTi/ArzTiServer/ArzTiServer.csproj", "ArzTi/ArzTiServer/"]
RUN dotnet restore "ArzTi/ArzTiServer/ArzTiServer.csproj"
COPY . .
WORKDIR "/src/ArzTi/ArzTiServer"
RUN dotnet build "ArzTiServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ArzTiServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ArzTiServer.dll"]