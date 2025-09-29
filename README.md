# Taller.API

This is the **Taller.API** project, a .NET application that uses SQL Server as its database.

---

## Prerequisites

Before starting, make sure you have installed:

- [.NET SDK 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Docker](https://www.docker.com/)
- SQL Server Management Studio or another SQL client (optional, for checking the database)

---

## Steps to run the application

### 1. Start the SQL Server container

From the root of the project, run:

```bash
docker-compose up -d
```

### 2. Execute the database initialization script

The project includes the Initial DB Script.sql file in the root, which creates the database and initial table.

- Open SQL Server Management Studio (or your preferred client).
- Connect to the SQL Server container (e.g., Server=.,1433;TrustServerCertificate=true;Encrypt=true).
- Run the Initial DB Script.sql script.
