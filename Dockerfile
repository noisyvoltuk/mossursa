# https://hub.docker.com/_/microsoft-dotnet-core
FROM mcr.microsoft.com/dotnet/core/sdk:6.0 AS build-env
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY noisysiteapp/*.csproj ./noisysiteapp/
RUN dotnet restore

# copy everything else and build app
COPY noisysiteapp/. ./noisysiteapp/
WORKDIR /source/noisysiteapp
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/core/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app ./
EXPOSE 80
ENTRYPOINT ["dotnet", "noisysiteapp.dll"]
