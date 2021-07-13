# Working-with-Forms
DEMO6_L2

**Creamos nuestro primer formulario.
</br></br>
**Se decoran las propiedades de la clase:**
</br>
<pre><code>
 [Display(Name = "Full Name:")]


 [Display(Name = "Email Address:")]
 [DataType(DataType.EmailAddress)]
 
 [Display(Name = "Password:")]
 [DataType(DataType.Password)]

</code></pre>

</br></br>
**En la vista importamos el modelo**
</br>
 @model DataAnnotationsExample.Models.User
</br></br>
**Y pintamos el formulario con tag helper**
      con el <label asp-for> pintamos el nombre de la propiedad y con el <input asp-for> pintamos el valor
<pre><code>
 <form asp-action="Details" method="post">
            <label asp-for="FullName"></label>
            <input asp-for="FullName" />
            <br />
            <label asp-for="Email"></label>
            <input asp-for="Email" />
            .
            .
            .
  </code></pre>
**En la vista Details.cshtml pitamos con html helper
con el @Html.DisplayNameFor pintamos el nombre de la propiedad y con el  @Html.DisplayFor pintamos el valor

<pre><code>
  <div>
            <span class="display-prop-name">
                @Html.DisplayNameFor(model => model.FullName)
            </span>
            <br />
            <span class="display-prop-value">
                @Html.DisplayFor(model => model.FullName)
            </span>
        </div>
  </code></pre>
  
