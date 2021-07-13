# How to Use Tag Helpers
</br>
<p>
  Se cambia el</br> 
  @Html.ActionLink("Employees", "Index", "Employee")</br></br>
</p>

<p>
por este otro
&lta asp-controller="Employee" asp-action="Index"&gtEmployees&lt/a&gt <br/>
</p>
<br/>

<p>
El resultado es el mismo que con @Html.ActionLink, se invoca al controlador y al action que a su vez redirijirá a la vista
</p>
