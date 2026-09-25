# Employee Management System

A portfolio-ready ASP.NET Core Web API demonstrating CRUD operations and clean application layering for employee records.

## Technology
- C# / ASP.NET Core 8 Web API
- Entity Framework Core + SQLite
- Repository and Service pattern
- DTO validation
- Swagger / OpenAPI
- Global exception middleware
- xUnit + Moq
- Dependency Injection

## API
| Method | Endpoint | Purpose |
|---|---|---|
| GET | `/api/employees` | List employees |
| GET | `/api/employees/{id}` | Get employee |
| POST | `/api/employees` | Create employee |
| PUT | `/api/employees/{id}` | Update employee |
| DELETE | `/api/employees/{id}` | Delete employee |

## Run
```bash
dotnet restore
dotnet run --project EmployeeManagement.API
```

Open the Swagger URL printed in the terminal and add `/swagger`.

## Test
```bash
dotnet test
```
