# TRN Generation API

## Overview

A service that facilitates the generation of unique TRNs (Teacher Reference Numbers) via a REST API.

## Setup

### Developer setup

The API is an ASP.NET Core 7 web application. To develop locally you will need the following installed:
- Visual Studio 2022 (or the .NET 7 SDK and an alternative IDE/editor);
- a local PostgreSQL 13+ instance;

#### Initial setup

Install PostgreSQL then add a connection string to user secrets for the `TrnGeneratorApi` and `TrnGeneratorApi.IntegrationTests` projects.

```shell
dotnet user-secrets --id TrnGeneratorApi set ConnectionStrings:DefaultConnection "Host=localhost;Username=your_postgres_user;Password=your_postgres_password;Database=trn_generator"
dotnet user-secrets --id TrnGeneratorApi.IntegrationTests set ConnectionStrings:DefaultConnection "Host=localhost;Username=your_postgres_user;Password=your_postgres_password;Database=trn_generator_tests"
```
Where `your_postgres_user` and `your_postgres_password` are the username and password of your Postgres installation, respectively.

Next set the API Key(s) you want to use to authenticate/authorize calls to the API for local development.

```shell
dotnet user-secrets --id TrnGeneratorApi set ApiKeys:0 "your_API_Key"
```

Where `your_API_Key` will be used in the `Authorization` header in calls to the API e.g. `Bearer your_API_Key`
