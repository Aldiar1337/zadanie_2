FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ConsoleApp5/ConsoleApp5.csproj", "ConsoleApp5/"]
RUN dotnet restore "ConsoleApp5/ConsoleApp5.csproj"
COPY . .
WORKDIR "/src/ConsoleApp5"
RUN dotnet build "ConsoleApp5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApp5.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp5.dll"]
