FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base

RUN apt-get update && apt-get install -y curl && rm -rf /var/lib/apt/lists/*

USER $APP_UID
WORKDIR /app
EXPOSE 8002
ENV ASPNETCORE_HTTP_PORTS=8002

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY BookMyHome.Application/BookMyHome.Application.csproj BookMyHome.Application/
COPY BookMyHome.Domain/BookMyHome.Domain.csproj BookMyHome.Domain/
COPY BookMyHome.Facade/BookMyHome.Facade.csproj BookMyHome.Facade/
COPY BookMyHome.Infrastructure/BookMyHome.Infrastructure.csproj BookMyHome.Infrastructure/

RUN dotnet restore "BookMyHome.Application/BookMyHome.Application.csproj"

COPY BookMyHome.Application/ BookMyHome.Application/
COPY BookMyHome.Domain/ BookMyHome.Domain/
COPY BookMyHome.Facade/ BookMyHome.Facade/
COPY BookMyHome.Infrastructure/ BookMyHome.Infrastructure/

FROM build AS publish
RUN dotnet publish "BookMyHome.Application/BookMyHome.Application.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BookMyHome.Application.dll"]
