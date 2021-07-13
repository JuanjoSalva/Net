### Using Entity Framework Core in ASP.NET Core

Laboratorio Módulo 7
Fichero de Instrucciones: Instructions\20486D_MOD07_LAK.md

Entregar el url de GitHub con la solución y un readme con las siguiente información:

Nombres y apellidos: Juan José Salvador Román

Fecha: 07/12/2020

Resumen del Ejercicio:

Creamos una aplicacion que guarda y recupera datos de una base de datos SQLLite.  Es una tienda online de cupcakes donde podemos ver una lista con imagenes de los cupcakes disponibles en la base de datos. Podemos editar, borrar y crear cupcakes.  Al gurdar datos y se guardan en la bse de datos sqlite que hemos instalado

Hay que instalar el plugin Microsoft.EntityFrameworkCore.Sqlite en el Manage Nuget Package

Creamos las clase del modelo:
Cupcake y Bakery
Se crea la clase que hereda de DBContext en la carpeta Data

Configuramos el startuo para traer el contexto de la base de datos
Ponemos código para que borre y Cree la bbdd con datos
Implementamos el método de crear la bbdd en la clase dentro de la carpeta Data

Creamos un pequeño repositorio, creando la carpeta Repositories
Aquí se crea la interface con los métodos y la clase que lo implementa: con los métodos de Get, Get por Id, Save, delete ... .

En el controlador se ponen todas las acciones asociadas a la bbdd con su vista. Se deoran co Httpost y httpGet

Con el Package Manager Console, se crea l aprimera vez la bbdd y se actualizan los datos.
Add-Migration InitialCreate  
Update-Database  

Al ejecutar:

![principal](https://github.com/JuanjoSalva/Using-Entity-Framework-Core-in-ASP.NET-Core/blob/master/Cupcakes/img/principal.PNG)



**Editar:**

![Editar](https://github.com/JuanjoSalva/Using-Entity-Framework-Core-in-ASP.NET-Core/blob/master/Cupcakes/img/Editar.PNG)

**Details:**

![details](https://github.com/JuanjoSalva/Using-Entity-Framework-Core-in-ASP.NET-Core/blob/master/Cupcakes/img/details.PNG)

**Crear:**

![Crear](https://github.com/JuanjoSalva/Using-Entity-Framework-Core-in-ASP.NET-Core/blob/master/Cupcakes/img/Crear.PNG)

**Delete:**

![delete](https://github.com/JuanjoSalva/Using-Entity-Framework-Core-in-ASP.NET-Core/blob/master/Cupcakes/img/delete.PNG)
