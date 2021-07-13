Working-with-Entity-Framework-Core
DEMO7_L2

Estamos usando SQLLIte. Cada vez que se ejecuta borra y crea la bbdd y mete los valores que tenemos en nuestro modelo.

Se añade el plugin de Microsoft.EntityFrameworkCore.Sqlite

modelo



protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity().HasData(
              new Person
              {
                  PersonId = 1,
                  FirstName = "Tara",
                  LastName = "Brewer",
                  City = "Ocala",
                  Address = "317 Long Street"
              },
              new Person
              {
                  PersonId = 2,
                  FirstName = "Andrew",
                  LastName = "Tippett",
                  City = "Anaheim",
                  Address = "3163 Nickel Road"
              });
        }

En el controlador vamos a construir las acciones para crear nuestro CRUD.

 //CREATE​

public IActionResult Create()​ 

{​ 

​	_context.Add(new Person() { FirstName = "Robert", LastName = "Berends", City = "Birmingham", Address = "2632 Petunia Way" }); _context.SaveChanges(); return RedirectToAction(nameof(Index)); }

![Create](https://github.com/JuanjoSalva/Working-with-Entity-Framework-Core/blob/master/EntityFrameworkExample/img/Create.PNG)




    //READ ALL
    public IActionResult Index()
    {
            return View(_context.People.ToList());
    }
    
    //READ ONLY ONE
    public IActionResult EditOne(int id)
    {
        var person = _context.People.SingleOrDefault(m => m.PersonId == id);
    
        if (person.FirstName == null)
                return Content("No existe en la bb");
        else
    
            return Content(person.FirstName);
    }

![1](https://github.com/JuanjoSalva/Working-with-Entity-Framework-Core/blob/master/EntityFrameworkExample/img/1.PNG)

//UPDATE
public IActionResult Edit(int id)
{
    var person = _context.People.SingleOrDefault(m => m.PersonId == id);
    person.FirstName = "Brandon";
    _context.Update(person);
    _context.SaveChanges();
    return RedirectToAction(nameof(Index));
}



![update](https://github.com/JuanjoSalva/Working-with-Entity-Framework-Core/blob/master/EntityFrameworkExample/img/update.PNG)

         //DELETE
    public IActionResult Delete(int id)
    {
        var person = _context.People.SingleOrDefault(m => m.PersonId == id);
        _context.People.Remove(person);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));



![delete](https://github.com/JuanjoSalva/Working-with-Entity-Framework-Core/blob/master/EntityFrameworkExample/img/delete.PNG)
