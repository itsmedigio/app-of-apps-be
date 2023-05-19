# Set the base image to the official .NET 6 SDK image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy the project files and restore dependencies
COPY . .
RUN dotnet restore
RUN dotnet build -c Release --no-restore
RUN dotnet publish -c Release --no-restore --output /app/out

# Set the base image to the official .NET 6 ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
EXPOSE 5000
ENV ASPNETCORE_URLS=http://+:5000
WORKDIR /app
COPY --from=build /app/out .

# Set the entry point of the application
ENTRYPOINT ["dotnet", "app-of-apps-be.dll"]
