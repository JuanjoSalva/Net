# Escenario son mejorados en 9.0

## Comparación de objetos (OK)

Clase Persona

Creamos p1 y p2 y p3

p1 = "John Doyle"

P3 = "John Doyle"

Es p1 igual a p3? R debería ser SI.

## Pasando por serialización (OK)

Serializamos p1

y recuperabamos (desserializabamos) p1 y lo almacenabamos en p3

Es p1 = p3?

CSharp 8 y anteriores versiones, hemos de implementar la Iterface

IEquatable<T>, 

## Inmutabilidad de los objetos o instancias

Objetos o instancias de Clases mutables:

​	En las propiedades definimos get y set (set);

Puedo hacer cambios? No hay set  no hay cambios.

R: Es complicada,  si no hay set



## Tuplas Nuevo desde CSharp 7.3

Que pasa si quiero pasar los valores de las propiedades de un objeto a variables:

1 - definir dos varialbes tipo string

string firstName = p1.FirstName;

string lastName = p1.LastName;

**var (firstName,lastName ) = p1;** DESTRUYERA O ME LA CONVIRTIERA.

# Records

inmutables por defecto

Con IEquatable

Con I....









