# SystemSales.Api

A layered **ASP.NET Core Web API** project for building sales-management functionality with a clear separation between API, business logic, data access, and infrastructure concerns.

## 🧱 Architecture

The solution is organized into separate projects:

- **SystemSales.Api** — HTTP API, controllers, configuration, and application entry point
- **SystemSales.Core** — core/domain layer
- **SystemSales.Service** — service/business logic layer
- **SystemSales.Data** — data-access layer
- **SystemSales.infrastructure** — infrastructure concerns

This structure keeps responsibilities separated and makes the application easier to maintain and extend.

## 🛠️ Technologies

- C#
- .NET 7
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI
- REST APIs

## ✨ Key Practices

- Layered architecture
- Separation of concerns
- Dependency Injection
- Entity Framework Core for data access
- RESTful API design
- Swagger/OpenAPI for API exploration and documentation

## 🚀 Getting Started

### Prerequisites

- .NET 7 SDK
- SQL Server
- Visual Studio 2022 or another compatible .NET IDE

### Run the project

1. Clone the repository.
2. Open `SystemSales.Api.sln`.
3. Configure the SQL Server connection string in the application settings.
4. Restore dependencies:

```bash
dotnet restore
```

5. Build the solution:

```bash
dotnet build
```

6. Run the API project:

```bash
dotnet run --project SystemSales.Api/SystemSales.Api.csproj
```

7. Open the generated Swagger endpoint to explore the available API endpoints.

## 📁 Solution Structure

```text
SystemSales.Api.sln
│
├── SystemSales.Api
├── SystemSales.Core
├── SystemSales.Service
├── SystemSales.Data
└── SystemSales.infrastructure
```

## 🎯 Purpose

This project demonstrates practical backend development with **ASP.NET Core**, relational database integration, layered architecture, and API documentation.
