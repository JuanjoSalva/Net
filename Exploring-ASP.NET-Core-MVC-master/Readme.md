##Introduction to ASP.NET Core MVC

Es una guía para que vayamos viendo los sigueinte elementos:

Como es la web resultante:

![Web](https://github.com/JuanjoSalva/Exploring-ASP.NET-Core-MVC/blob/master/PhotoSharingSample/img/Web.PNG)



Controlador:  accion index devuelve una lista



![controller_action_index](https://github.com/JuanjoSalva/Exploring-ASP.NET-Core-MVC/blob/master/PhotoSharingSample/img/controller_action_index.PNG)



Index.cshtml:  ver que importamos el modelo

![index](https://github.com/JuanjoSalva/Exploring-ASP.NET-Core-MVC/tree/master/PhotoSharingSample/img/index.PNG)



Startup.cd o MiddleWare: ver que estamos usando las rutras por defecto

![middleware](https://github.com/JuanjoSalva/Exploring-ASP.NET-Core-MVC/blob/master/PhotoSharingSample/img/middleware.PNG)



modelo: ver la propiedad Title del modelo Photo. Además vemos que es un campo requerido con lo que si se habilita la validaciones de formulario pues se tendrá en cuenta.

![image-20201127164015200](https://github.com/JuanjoSalva/Exploring-ASP.NET-Core-MVC/blob/master/PhotoSharingSample/img/image-20201127164015200.png)



home_controller:  ver como se hereda la clase base Controller 

![controller_implementacion](https://github.com/JuanjoSalva/Exploring-ASP.NET-Core-MVC/blob/master/PhotoSharingSample/img/controller_implementacion.PNG)



home_controller: La acion Index

![controller_getImage](https://github.com/JuanjoSalva/Exploring-ASP.NET-Core-MVC/blob/master/PhotoSharingSample/img/controller_getImage.PNG)



**La vista Index.cshtml**  El div que muestra las imagenes

![div_imagenes](https://github.com/JuanjoSalva/Exploring-ASP.NET-Core-MVC/blob/master/PhotoSharingSample/img/div_imagenes.PNG)

