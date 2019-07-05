FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Scaledriven.Api/*.csproj ./Scaledriven.Api/
COPY Scaledriven.Core/*.csproj ./Scaledriven.Core/
RUN dotnet restore Scaledriven.Api/Scaledriven.Api.csproj
RUN dotnet restore Scaledriven.Core/Scaledriven.Core.csproj

# copy everything else and build app
COPY Scaledriven.Api/. ./Scaledriven.Api/
COPY Scaledriven.Core/. ./Scaledriven.Core/
WORKDIR /app/Scaledriven.Api
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/Scaledriven.Api/out ./
ENTRYPOINT ["dotnet","Scaledriven.Api.dll"]
