#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Api.Web/Api.Web.csproj", "Api.Web/"]
COPY ["Api.Application/Api.Application.csproj", "Api.Application/"]
COPY ["Api.Services/Api.Services.csproj", "Api.Services/"]
COPY ["Api.Infrastructure/Api.Infrastructure.csproj", "Api.Infrastructure/"]
COPY ["Api.Interface/Api.Interface.csproj", "Api.Interface/"]
COPY ["Api.Domain/Api.Domain.csproj", "Api.Domain/"]
RUN dotnet restore "Api.Web/Api.Web.csproj"
COPY . .
WORKDIR "/src/Api.Web"
RUN dotnet build "Api.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Web.dll"]
