## Laboratorio Módulo 3

Fichero de Instrucciones: Instructions\20486D_MOD03_LAK.md

Entregar el url de GitHub con la solución y un readme con las siguiente información:

1. **Nombres y apellidos:**Juan José Saalvador Román
2. **Fecha:** 27/11/2020
3. **Resumen del Ejercicio:** A partir de la linea 12 
4. **Dificultad o problemas presentados y como se resolvieron:** Errores en la consola del programa, la página web no realizaba los cambios solicitados, etc.

# Configuring-Middleware-and-Services-in-ASP.NET-Core
## DEMO3 LAK

**Info:**
Aplicacion de pelotas favoritas donde aparece una página inicial con pelotas, aquí seleccionas tu favorita y pulsas submit. Te redirije a otra pantalla que agradece el haber   
elegido tu favorita y un enlace para ver las selecciones. Éste enlace te muestra otra página con las selecciones que se vab haciendo.

**StratUp o MiddleWare** que invoca al mvc con lo que deja el mando al controlador
Controller que con el static-file te abre la página que hay en wwwroot. 

Primero el Starup o MiddleWare comprueba si la url contiene favorite. Si es así muestra la página dando las gracias y con el enlace a la lista de favoritos. Si no  
da el relevo al mvc que invoca al controlador.   Este pregunta si laurl contiene la palabra submit. Si es así muestra la lista de favoritos y si no muestra la página de  
inicio con las pelotas

Con **inyeccion de dependencia** y Service.AddSingleton le inyectamos nuestra clase e Interface que guarda las votaciones de las pelotas favoritas. Al ser Sigleton se almacena  
aún si cambiamos de navegador


