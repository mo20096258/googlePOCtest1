# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY devNXT/*.csproj ./devNXT/
RUN dotnet restore

# copy everything else and build app
COPY devNXT/. ./devNXT/
WORKDIR /source/devNXT
RUN dotnet build -c Release -o /app/build
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "devNXT.dll"]
