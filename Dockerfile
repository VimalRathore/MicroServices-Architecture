#Build
FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build-env
WORKDIR /FindnChitChats
COPY . .
RUN dotnet restore
RUN dotnet publish -o /publish
WORKDIR /publish
ENTRYPOINT ["dotnet", "FindnChitChat.dll"]