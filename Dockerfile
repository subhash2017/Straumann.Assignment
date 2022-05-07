#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Straumann.Assignment/Straumann.Assignment.csproj", "Straumann.Assignment/"]
RUN dotnet restore "Straumann.Assignment/Straumann.Assignment.csproj"
COPY . .
WORKDIR "/src/Straumann.Assignment"
RUN dotnet build "Straumann.Assignment.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Straumann.Assignment.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Straumann.Assignment.dll"]