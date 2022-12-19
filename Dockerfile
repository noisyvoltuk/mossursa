# https://hub.docker.com/_/microsoft-dotnet-core
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY mossursa/*.csproj ./mossursa/
RUN dotnet restore

# copy everything else and build app
COPY mossursa/. ./mossursa/
WORKDIR /source/mossursa
RUN dotnet publish -c release -o /app 

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app ./
EXPOSE 80
ENTRYPOINT ["dotnet", "mossursa.dll"]
