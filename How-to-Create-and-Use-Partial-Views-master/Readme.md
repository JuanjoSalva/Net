#How to Create and Use Partial Views

**ViewPartial**
En este ejercicio vemos el uso de las Partial View, que son trozos de p�ginas html que se inserta en otra principal. As�, si hay una
parte de varias p�ginas web que se est� repitiendo podr�amos hacer una partial view con ese c�digo que se repite e incluirlo en las principales.
De esta manera s�lo se hace una vez y es m�s f�cil de mantener y modificar.
Estas Partial View van en la carpeta Shared dentro de la carpeta View 


En este ejercicio, se crea la Vista Parcial, _CardDesign.cshtml, a la que se pasa como parametro un id, que ser� la posicion de la lista
y que tiene el siguente c�digo:
<td>
    <div>First Name: @ViewBag.People[Model].FirstName</div>
    <div>Last Name: @ViewBag.People[Model].LastName</div>
    <div>Residence: @ViewBag.People[Model].Address</div>
    <div>Phone: @ViewBag.People[Model].PhoneNumber</div>
</td>


Desde la principal se incrusta la Vista Parcial  dentro de un foreach, lo que har� que se repita la vista parcial. A la vista parcial se le
pasa el interador del foreach
	@await Html.PartialAsync("_CardDesign", cardIndex);
            }