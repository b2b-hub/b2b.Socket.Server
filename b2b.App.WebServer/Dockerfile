#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["b2b.Socket.Server/b2b.Socket.Server.csproj", "b2b.Socket.Server/"]
RUN dotnet restore "b2b.Socket.Server/b2b.Socket.Server.csproj"
COPY . .
WORKDIR "/src/b2b.Socket.Server"
RUN dotnet build "b2b.Socket.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "b2b.Socket.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "b2b.Socket.Server.dll"]