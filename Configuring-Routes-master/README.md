# Configuring-Routes

Esto es para configurar las rutas en el controlador.  

**Enrutamiento Convencional:**

 app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "firstRoute",
                    template: "{controller}/{action}/{num:int}");

                routes.MapRoute(
                    name: "secondRoute",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });
            });
            
** Enrutamiento por atributo**

 [Route("Hello/{firstName}/{lastName}")]
        public IActionResult Greeting(string firstName, string lastName)
        
 - Ruta con propiedad predeterminada
