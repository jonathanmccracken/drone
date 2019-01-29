FROM microsoft/dotnet:2.2.103-sdk-alpine3.8 AS build-env
WORKDIR /app

# Copy from local computer to container
COPY src ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:2.1.7-aspnetcore-runtime-alpine3.7
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "drone.dll"]