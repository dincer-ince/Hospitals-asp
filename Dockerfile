FROM mcr.microsoft.com/dotnet/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443



FROM mcr.microsoft.com/dotnet/sdk:3.1-buster AS build
WORKDIR /src
COPY ["./covid_backend.csproj", "covid_backend_build/"]
RUN dotnet restore "covid_backend_build\covid_backend.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "covid_backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "covid_backend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet HerokuDockerDeployment.dll

