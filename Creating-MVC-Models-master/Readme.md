#Creating MVC Models

**Creamos nuestro primer modelo. Que se pasará a la vista através del controlador

<pre>code>
public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Open { get; set; }
        public string Speciality { get; set; }
        public int Review { get; set; }
    }
</code></pre>
 **En el controlador pasamos a la vista un objeto restaurant de la clase Restaurant
 
 <pre>code>
  public IActionResult Index()
        {
            Restaurant restaurant = new Restaurant() { Id = 1, Name = "My Kitchen 1", Address = "New Brunswick, 
            2657 Webster Street", Speciality = "Hamburgers", Open = true,       Review = 4 };
            
            return View(restaurant);
        }
</code></pre>

**En la vista lo recogemos**
@model BindViewsExample.Models.Restaurant
**y lo pintamos**
<p><b>Name</b>: @Model.Name</p>
<hr />
<p><b>Address</b>: @Model.Address</p>
.
.
.
