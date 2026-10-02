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

FROM build AS publish
RUN dotnet publish "BookMyHome.Presentation/BookMyHome.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/publish

# Blazor WebAssembly is static files only, so it is served by nginx instead of the ASP.NET runtime
FROM nginx:alpine AS final

RUN apk add --no-cache curl

COPY nginx.conf /etc/nginx/conf.d/default.conf
COPY --from=publish /app/publish/wwwroot /usr/share/nginx/html

EXPOSE 8001