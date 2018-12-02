# Build stage
FROM microsoft/dotnet:2.1.500-sdk-alpine as publish

RUN apk update && apk upgrade --no-cache

COPY src /src
WORKDIR /src

RUN dotnet publish -c Release


# Run stage
FROM microsoft/dotnet:2.1.6-aspnetcore-runtime-alpine as run

RUN apk update && apk upgrade --no-cache

COPY --from=publish /src/bin/Release/netcoreapp2.1/publish /app
WORKDIR /app

EXPOSE 9092/tcp
ENV ASPNETCORE_URLS http://*:9092

ARG ASPNETCORE_ENVIRONMENT
ARG APP_NAME
ARG OBJECT_URL
ARG STORAGE_URL
ARG RULES_URL
ARG INDEXING_URL

ENV ASPNETCORE_ENVIRONMENT ${ASPNETCORE_ENVIRONMENT}
ENV APP_NAME ${APP_NAME}
ENV OBJECT_URL ${OBJECT_URL}
ENV STORAGE_URL ${STORAGE_URL}
ENV RULES_URL ${RULES_URL}
ENV INDEXING_URL ${INDEXING_URL}

# pull latest
RUN apk update && apk upgrade --no-cache

# don't run as root user
RUN chown 1001:0 /app/Foundation.Example.WebUI.dll
RUN chmod g+rwx /app/Foundation.Example.WebUI.dll
USER 1001

ENTRYPOINT [ "dotnet", "Foundation.Example.WebUI.dll" ]

