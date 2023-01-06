FROM bancopichinchaec.azurecr.io/bp/cross-iac/dotnet/dotnet-6-runtime-debian
COPY ./publish/. .

CMD ["dotnet", "WSProductos0314.API.dll"]