# Install stuff

- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet add package Microsoft.EntityFrameworkCore.InMemory 


# Run microsoft sql in the container 

Run db: `docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=strong123#" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-CU14-ubuntu-20.04`


# Create database

Tool: https://dbeaver.io/

```
CREATE DATABASE todos;

USE todos;

CREATE TABLE [dbo].Todo (
	[Id] [int] IDENTITY(1,1),
	[Name] [nvarchar](500)
);

SELECT * FROM  Todo t ;
```
