#How to Create and Use View Components

En este ejercicio se hace uso de componentes de vista: ** @await Component.InvokeAsync("PersonCard", cardIndex);**

Los componentes de vista son similares a las vistas parciales, pero mucho m�s eficaces. Los componentes de vista no usan el enlace de 
modelos y solo dependen de los datos proporcionados cuando se les llama

Esto lo que hace es incrustar un componentes de vista en una p�gina principal. Es lo mismo que una **vista parcial 
@await Html.PartialAsync("_CardDesign", cardIndex);**, pero en este caso los componentes de vista se guardan en una carpeta que estar� 
dentro de otra llamada Component que est� a nivel de proyecto.

Los componentes de vista est�n dise�ados para cualquier lugar que tenga l�gica de representaci�n reutilizable demasiado compleja para una vista parcial, como:
Men�s de navegaci�n din�mica
Nube de etiquetas (donde consulta la base de datos)
Panel de inicio de sesi�n
Carro de la compra
Art�culos publicados recientemente
Contenido de la barra lateral de un blog t�pico
Un panel de inicio de sesi�n que se representa en cada p�gina y muestra los v�nculos para iniciar o cerrar sesi�n, seg�n el estado del usuario