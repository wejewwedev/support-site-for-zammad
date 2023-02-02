FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Logus.SupportPage/Logus.SupportPage.csproj", "Logus.SupportPage/"]
RUN dotnet restore "Logus.SupportPage/Logus.SupportPage.csproj"
COPY . .
WORKDIR "/src/Logus.SupportPage"
RUN dotnet build "Logus.SupportPage.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Logus.SupportPage.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
RUN apt-get update && apt-get install -y locales

RUN sed -i -e \
  's/ru_RU.UTF-8 UTF-8/ru_RU.UTF-8 UTF-8/' /etc/locale.gen \
   && locale-gen

ENV LANG ru_RU.UTF-8
ENV LANGUAGE ru_RU:ru
ENV LC_LANG ru_RU.UTF-8
ENV LC_ALL ru_RU.UTF-8
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Logus.SupportPage.dll"]