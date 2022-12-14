FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
WORKDIR /app
EXPOSE 5218

ENV ASPNETCORE_URLS=http://+:5218
ENV ASPNETCORE_ENVIRONMENT=Development

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["LomasFormApi/LomasFormApi.csproj", "LomasFormApi/"]
RUN dotnet restore "LomasFormApi/LomasFormApi.csproj"
COPY . .
WORKDIR "/src/LomasFormApi"
RUN dotnet build "LomasFormApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LomasFormApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LomasFormApi.dll"]
