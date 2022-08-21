FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80
COPY Shared/*.csproj Shared/
COPY StockAPI/*.csproj StockAPI/
RUN dotnet restore StockAPI/*.csproj
COPY . .
RUN dotnet publish StockAPI/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","StockAPI.dll" ]