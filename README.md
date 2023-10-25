# SwaggerAPi

Ejemplo api mínima implementando Swagger

Faltaría crear vuestra base de datos sql server con la tabla Users

SCRIPT TABLA ---> 

CREATE TABLE [dbo].[Users] (
    [Id]   INT           NOT NULL,
    [Name] NVARCHAR (50) NULL,
    [Age]  INT           NULL
);

COMANDO NUGET CREAR DBCONTEXT  (Database first, esta opcion no es la buena) --> Scaffold-DbContext "cadena TU BASE DE DATOS" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

Dependencias que se tienen que instalar en el proyecto:
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools
  - Swashbuckle.AspNetCore
  - Swashbuckle.AspNetCore.Swagger


