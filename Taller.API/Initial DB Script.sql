
CREATE DATABASE [taller-db-dev];
USE [taller-db-dev];

CREATE TABLE Reports
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Title NVARCHAR(200) NOT NULL,
        Content NVARCHAR(MAX) NULL,
        Status NVARCHAR(50) NOT NULL,
        CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
    );