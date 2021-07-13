## Usando SQL Server en Local y en Azure con EF y Asp.NET Core 5.0

En esta pr�ctica se explica el funcionamiento de ASP.NET Core MVC y Entity Framework Core con controladores y vistas. Razor Pages es un modelo de programaci�n alternativo. Para un nuevo desarrollo, se recomienda Razor Pages antes que MVC con controladores y vistas. Vea una versi�n de Razor Pages de este tutorial. 

### Cadena de conexi�n inicial a SQL Local

```
Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ContosoUniversity;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
```


### Cadena de conexion a SQL Database en Azure

```
"Server=tcp:adventureworksbmvb.database.windows.net,1433;Initial Catalog=ContosoUniversity;Persist Security Info=False;User ID=manager;Password=YOURPASSWORD;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
```


### Codigo para migraci�n de codigo desde Azure a DB

```
PM> Add-Migration InitialCreate
PM> Update-Database
```

Mayor Informacion en el siguiente enlace de la pr�ctica
https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0

NOTA: Todo finalizado

