## Laboratorio Módulo 6

Fichero de Instrucciones: Instructions\20486D_MOD06_LAK.md

Entregar el url de GitHub con la solución y un readme con las siguiente información:

1. **Nombres y apellidos:** Juan José Salvador Román
2. **Fecha:** 27/11/2020
3. **Resumen del Ejercicio:** A partir de la linea 13
4. **Dificultad o problemas presentados y como se resolvieron:**


# Developing Models     MOD6_LAK

**MVC
Una tienda de mariposas que muestra una lista de mariposas.  Tiene un botón para añadir otra mariposa que nos lleva a otra página
que presenta un formulario que crea automáticamente a  partir del modelo. Metemos los datos y damos al botón de añadir que envía 
los datos con POST. Estos se validan en el propio formulario antes de ser enviados y si está todo ok pues se muestra la página inicial
con las mariposas de la lista más la nueva que hemos añadido. Si no es correcto muestra los errores en la página del formulario**


### Exercise 1: Añadimos el Modelo
#### Task 1: Creamos un nuevo modelo, clase mariposa
#### Task 2: Usamos el modelo en la vista.  
#### Task 3: Le pasamos una lista de mariposas a la vista con el controlador
#### Task 4: Run the application
#### Task 5: Escribimos una acción Get 
#### Task 6: Escribimos una acción Post que acepta el modelo

### Exercise 2: TRabajando con formularios
#### Task 1: Decoramos los atributis de la clase con anotaciones Display y Edit  
#### Task 2: Creamos una acción Update anque retorna el contenido de un fichero
#### Task 3: Añadimos los display helper
#### Task 4: Añadimos Form Helpers
#### Task 5: Añadimos Editor Helpers

### Exercise 3: Añadimos Validación a los campos del formulario

#### Task 1: Decoramos las propiesdades del modelo con restricciones o validaciones
#### Task 2: Añadimos a la vista los validation helpers.
#### Task 3: Agregamos la propiedad ModelState.IsValid en un controlador para que muestre la vista si los datois ha sido correctos
#### Task 4: Run the application
#### Task 5: Añadimos validacion personalizada creando la carpeta Validator y una clase con validaciones

