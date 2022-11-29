FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CV19WpfConsole/CV19WpfConsole.csproj", "CV19WpfConsole/"]
RUN dotnet restore "CV19WpfConsole/CV19WpfConsole.csproj"
COPY . .
WORKDIR "/src/CV19WpfConsole"
RUN dotnet build "CV19WpfConsole.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CV19WpfConsole.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CV19WpfConsole.dll"]
