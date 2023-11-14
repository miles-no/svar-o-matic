FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["backend-placeholder/backend-placeholder.csproj", "backend-placeholder/"]
RUN dotnet restore "backend-placeholder/backend-placeholder.csproj"
COPY . .
WORKDIR "/src/backend-placeholder"
RUN dotnet build "backend-placeholder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "backend-placeholder.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "backend-placeholder.dll"]
