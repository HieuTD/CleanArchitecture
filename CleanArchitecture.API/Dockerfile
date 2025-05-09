# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution và các project
COPY CleanArchitecture.sln .
COPY CleanArchitecture.API/CleanArchitecture.API.csproj ./CleanArchitecture.API/
COPY CleanArchitecture.Application/CleanArchitecture.Application.csproj ./CleanArchitecture.Application/
COPY CleanArchitecture.Domain/CleanArchitecture.Domain.csproj ./CleanArchitecture.Domain/
COPY CleanArchitecture.Infrastructure/CleanArchitecture.Infrastructure.csproj ./CleanArchitecture.Infrastructure/

# Restore
RUN dotnet restore

# Copy toàn bộ source
COPY . .

# Build và publish
WORKDIR /src/CleanArchitecture.API
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Run
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
EXPOSE 8081
ENTRYPOINT ["dotnet", "CleanArchitecture.API.dll"]
