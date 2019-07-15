FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Scaledriven/*.csproj ./Scaledriven/
RUN dotnet restore Scaledriven/Scaledriven.csproj

# copy everything else and build app
COPY Scaledriven/ ./Scaledriven/
WORKDIR /app/Scaledriven
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/Scaledriven/out ./
ENTRYPOINT ["dotnet","Scaledriven.dll"]
