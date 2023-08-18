#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY *.sln .
COPY ["PostgresEnumPrototype/PostgresEnumPrototype.csproj", "PostgresEnumPrototype/"]
RUN dotnet restore "PostgresEnumPrototype/PostgresEnumPrototype.csproj"
COPY . .
WORKDIR /src/PostgresEnumPrototype
RUN dotnet build "PostgresEnumPrototype.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PostgresEnumPrototype.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PostgresEnumPrototype.dll"]
