# CompanyRegistryManagementSystem-
Developed a .NET 8 Web API for Company Registry CRUD operations using Onion Architecture. Implemented separate class libraries, Dependency Injection, SOLID principles, Entity Framework Core, AutoMapper, DTOs, and JWT Authentication. Successfully tested APIs using Swagger and Postman.



````md
# Company Registry Management System

## Project Overview

Company Registry Management System is a .NET 8 Web API project developed using Onion Architecture principles. The application performs CRUD (Create, Read, Update, Delete) operations for managing company registry data while following clean architecture and best coding practices.

The project is designed with a layered architecture approach where each responsibility is separated into different class libraries to improve maintainability, scalability, and code reusability.

---

# Features

* CRUD Operations for Company Registry
* Onion Architecture Implementation
* Separate Class Libraries for Each Layer
* Dependency Injection (DI)
* SOLID Principles
* Entity Framework Core
* SQL Server Database Integration
* AutoMapper Integration
* DTO (Data Transfer Object) Pattern
* JWT Authentication & Authorization
* Swagger API Documentation
* Postman API Testing
* Clean and Maintainable Code Structure

---

# Technologies Used

* ASP.NET Core 8 Web API
* C#
* Entity Framework Core
* SQL Server
* JWT Bearer Authentication
* AutoMapper
* Swagger / Swashbuckle
* Dependency Injection
* Onion Architecture

---

# Architecture

The project follows Onion Architecture to separate concerns into multiple layers.

## Project Structure

```text
CurdOperationWithOnionArchitecture
│
├── CurdOperationWithOnionArchitecture
│   ├── Controllers
│   ├── Program.cs
│   ├── appsettings.json
│
├── CurdOperationWithOnionArchitecture.Services
│   ├── Business Logic
│   ├── Service Interfaces
│
├── CurdOperationWithOnionArchitecture.DataAccessLayer
│   ├── DbContext
│   ├── Entity Models
│   ├── EF Core Migrations
│
├── CurdOperationWithOnionArchitecture.DTO
│   ├── Request DTOs
│   ├── Response DTOs
````

---

# Design Principles Used

## SOLID Principles

The project follows SOLID principles for better software design:

* Single Responsibility Principle
* Open/Closed Principle
* Liskov Substitution Principle
* Interface Segregation Principle
* Dependency Inversion Principle

---

# Dependency Injection

Dependency Injection is implemented to achieve loose coupling between services and improve testability and maintainability.

Example:

```csharp
builder.Services.AddScoped<IComRegistryServices, ComRegistryServises>();
```

---

# JWT Authentication

JWT Authentication is implemented to secure API endpoints.

Features:

* Token Generation
* Token Validation
* Protected APIs using `[Authorize]`
* Swagger JWT Authorization Support

---

# AutoMapper

AutoMapper is used for mapping:

* Entity Models ↔ DTOs

This reduces manual mapping code and improves maintainability.

---

# Database

* SQL Server Database
* Entity Framework Core Code First Approach
* EF Core Migrations

---

# API Testing

The APIs were successfully tested using:

* Swagger UI
* Postman

---

# CRUD Operations

The application supports:

* Create Company Record
* Get Company Records
* Update Company Record
* Delete Company Record

---

# Swagger Integration

Swagger is integrated for API documentation and endpoint testing.

Features:

* API Endpoint Documentation
* JWT Authorization Support
* Request/Response Testing

---

# How to Run the Project

## Clone Repository

```bash
git clone https://github.com/TANGUDU12RAJA12/CompanyRegistryManagementSystem-.git
```

---

## Navigate to Project

```bash
cd CompanyRegistryManagementSystem-
```

---

## Restore Packages

```bash
dotnet restore
```

---

## Update Database

```bash
dotnet ef database update
```

---

## Run Application

```bash
dotnet run
```

---

# Future Improvements

* Refresh Token Implementation
* Global Exception Handling Middleware
* Repository Pattern
* Unit Testing
* Role-Based Authorization
* Logging with Serilog
* API Versioning
* Docker Support
* Azure Deployment

---

# Learning Outcomes

Through this project, I gained practical experience in:

* Building REST APIs using ASP.NET Core
* Implementing Onion Architecture
* Applying SOLID Principles
* Working with Entity Framework Core
* Implementing JWT Authentication
* Using Dependency Injection
* API Testing with Swagger and Postman
* Git & GitHub Version Control

---

# Author

Developed by Raja Tangu

```
```

