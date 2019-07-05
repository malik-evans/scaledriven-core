FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Scaledriven.Client/*.csproj ./Scaledriven.Client/
COPY Scaledriven.Core/*.csproj ./Scaledriven.Core/
RUN dotnet restore Scaledriven.Client/Scaledriven.Client.csproj
RUN dotnet restore Scaledriven.Core/Scaledriven.Core.csproj

# copy everything else and build app
COPY Scaledriven.Client/. ./Scaledriven.Client/
COPY Scaledriven.Core/. ./Scaledriven.Core/
WORKDIR /app/Scaledriven.Client
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/Scaledriven.Client/out ./
ENTRYPOINT ["dotnet","Scaledriven.Client.dll"]
