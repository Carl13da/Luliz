FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 52355
EXPOSE 44394

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY LuLiz.Web/LuLiz.Web.csproj LuLiz.Web/
RUN dotnet restore LuLiz.Web/LuLiz.Web.csproj
COPY . .
WORKDIR /src/LuLiz.Web
RUN dotnet build LuLiz.Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish LuLiz.Web.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LuLiz.Web.dll"]
