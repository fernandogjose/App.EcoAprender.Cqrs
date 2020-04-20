FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["Src/App.EcoAprender.Cqrs.Api/App.EcoAprender.Cqrs.Api.csproj", "Src/App.EcoAprender.Cqrs.Api/"]
COPY ["Src/App.EcoAprender.Cqrs.Infra.CrossCutting.IoC/App.EcoAprender.Cqrs.Infra.CrossCutting.IoC.csproj", "Src/App.EcoAprender.Cqrs.Infra.CrossCutting.IoC/"]
COPY ["Src/App.EcoAprender.Cqrs.Application/App.EcoAprender.Cqrs.Application.csproj", "Src/App.EcoAprender.Cqrs.Application/"]
COPY ["Src/App.EcoAprender.Cqrs.Domain/App.EcoAprender.Cqrs.Domain.csproj", "Src/App.EcoAprender.Cqrs.Domain/"]
COPY ["Src/App.EcoAprender.Cqrs.Infra.Data.Dapper/App.EcoAprender.Cqrs.Infra.Data.Dapper.csproj", "Src/App.EcoAprender.Cqrs.Infra.Data.Dapper/"]
RUN dotnet restore "Src/App.EcoAprender.Cqrs.Api/App.EcoAprender.Cqrs.Api.csproj"
COPY . .
WORKDIR "/src/Src/App.EcoAprender.Cqrs.Api"
RUN dotnet build "App.EcoAprender.Cqrs.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "App.EcoAprender.Cqrs.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "App.EcoAprender.Cqrs.Api.dll"]