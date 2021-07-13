#How to Create and Use View Components

En este ejercicio se hace uso de componentes de vista: ** @await Component.InvokeAsync("PersonCard", cardIndex);**

Los componentes de vista son similares a las vistas parciales, pero mucho más eficaces. Los componentes de vista no usan el enlace de 
modelos y solo dependen de los datos proporcionados cuando se les llama

Esto lo que hace es incrustar un componentes de vista en una página principal. Es lo mismo que una **vista parcial 
@await Html.PartialAsync("_CardDesign", cardIndex);**, pero en este caso los componentes de vista se guardan en una carpeta que estará 
dentro de otra llamada Component que está a nivel de proyecto.

Los componentes de vista están diseñados para cualquier lugar que tenga lógica de representación reutilizable demasiado compleja para una vista parcial, como:
Menús de navegación dinámica
Nube de etiquetas (donde consulta la base de datos)
Panel de inicio de sesión
Carro de la compra
Artículos publicados recientemente
Contenido de la barra lateral de un blog típico
Un panel de inicio de sesión que se representa en cada página y muestra los vínculos para iniciar o cerrar sesión, según el estado del usuario