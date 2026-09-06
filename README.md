# SystemSales.Api

A .NET 7 ASP.NET Core Web API for sales-management workflows. The API exposes operations for branches, customers, and customer transactions.

## Tech Stack

- C# and .NET 7
- ASP.NET Core Web API
- Entity Framework Core 7 with SQL Server
- Swagger/OpenAPI
- MediatR and AutoMapper
- EF Core migrations

## Architecture

```text
SystemSales.Api            HTTP controllers and application startup
SystemSales.Core           domain types, requests, responses, and MediatR handlers
SystemSales.Service        application services
SystemSales.Data           data-layer project
SystemSales.infrastructure EF Core context, migrations, repositories, and DI setup
```

Controllers delegate work to the application layers. The infrastructure project registers persistence and repository dependencies; EF Core is configured with SQL Server in the API startup.

## Key Features

- REST endpoints for branches, customers, and transactions
- SQL Server persistence through `ApplicationDbContext`
- Repository interfaces and implementations, including a generic asynchronous repository
- MediatR command/query handlers for business workflows
- Swagger UI for interactive API exploration
- EF Core migrations for schema changes

## Authentication and Security

This repository does not configure an authentication scheme or authorization policy in `Program.cs`. Do not treat it as production-ready for protected APIs until authentication, authorization, secret management, and environment-specific configuration are added.

## API Documentation

Swagger is registered in the API startup. Run the API and open the Swagger UI at the URL shown by the application (commonly `/swagger`).

## Run Locally

### Prerequisites

- .NET 7 SDK
- SQL Server

### Steps

1. Configure the `DefualtConnection` connection string in the API project configuration. Use local user secrets or an environment-specific file for real credentials; never commit them.
2. Restore and build the solution:

```bash
dotnet restore
dotnet build
```

3. Apply migrations if the database has not been created:

```bash
dotnet ef database update --project SystemSales.infrastructure --startup-project SystemSales.Api
```

4. Start the API:

```bash
dotnet run --project SystemSales.Api/SystemSales.Api.csproj
```

## Engineering Notes

The project demonstrates layered organization, dependency injection, EF Core persistence, repository abstractions, and MediatR-based handlers. No automated test project, Dockerfile, or compose configuration is currently present in the repository.
