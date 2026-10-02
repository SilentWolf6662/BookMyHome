FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base

RUN apt-get update \
	&& apt-get install -y curl \
	&& rm -rf /var/lib/apt/lists/*

WORKDIR /app
EXPOSE 8001
ENV ASPNETCORE_URLS=http://+:8001

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY BookMyHome.Application/BookMyHome.Application.csproj BookMyHome.Application/
COPY BookMyHome.Domain/BookMyHome.Domain.csproj BookMyHome.Domain/
COPY BookMyHome.Facade/BookMyHome.Facade.csproj BookMyHome.Facade/
COPY BookMyHome.Infrastructure/BookMyHome.Infrastructure.csproj BookMyHome.Infrastructure/
COPY BookMyHome.Presentation/BookMyHome.Presentation.csproj BookMyHome.Presentation/

RUN dotnet restore "BookMyHome.Presentation/BookMyHome.Presentation.csproj"

COPY BookMyHome.Application/ BookMyHome.Application/
COPY BookMyHome.Facade/ BookMyHome.Facade/
COPY BookMyHome.Domain/ BookMyHome.Domain/
COPY BookMyHome.Infrastructure/ BookMyHome.Infrastructure/
COPY BookMyHome.Presentation/ BookMyHome.Presentation/

RUN dotnet build "BookMyHome.Presentation/BookMyHome.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
RUN dotnet publish "BookMyHome.Presentation/BookMyHome.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "BookMyHome.Presentation.dll"]