### Applying Styles BootStrap

Usamos BootStrap. Para ello instalamos el npm en la carpeta del proyecto con el siguiente  comando
	npm install
para crear la carpeta node_modules e integrar el framework Bootstrap en el proyecto

Por defecto al crear un proyecto MVC nos crea en la carpeta Views. En ella creamos la subcarpeta Shared y el fichero _Layout.cshtml. Esta página es la plantilla que usará el asistente de las vistas cuando no seleccionamos ninguna. Es el equivalente a las MasterPages en WebPages, es decir la plantilla común para todas las páginas de nuestro sitio. El contenido por defecto de la plantilla será

    <div class="view-container">
        @RenderBody()
    </div>
@RenderBody() Se utiliza en _layout.cshtml para indicar que en ese punto se incluirá el código generado por la vista.

Todos los layouts deben incluirla. En caso de no hacerlo obtendremos el siguiente mensaje de error.


En esta demostración, primero aprenderá a usar npm para agregar Bootstrap y sus dependencias a una aplicación ASP.NET Core. Después de eso, aprenderá cómo agregar componentes Bootstrap a la aplicación.


Aplicaciones con estilo con Sass
Instalando Sass con npm
npm install -g sass

Compilando ficheros Sass 
sass main.scss main.css

Agregamos un archivo Sass a su aplicación agregando un archivo que termine con la extensión .scss a su proyecto. Luego deberá compilar el archivo Sass en un archivo CSS.
