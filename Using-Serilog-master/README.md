## DEMO8_L1_2

### Using Serilog

Creamos una webapi

dotnet new webapi -n Mod8Demo2SerilogStarter -f netcoreapp2.1   

![cramoswebapi](img/cramoswebapi.PNG)



Añadimos paquete Serilog.AspNetCore

dotnet add package Serilog.AspNetCore --version 2.1.1

![anadimospackage](img/anadimospackage.PNG)



añadimos paquete Serilog Colored Console

dotnet add package Serilog.Sinks.ColoredConsole --version 3.0.1

![anadimospackage2](img/anadimospackage2.PNG)

añadimos code al Program.cs

using Serilog;

​	

.UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration
    .ReadFrom.Configuration(hostingContext.Configuration)
    .Enrich.FromLogContext()
    .WriteTo.Console());

Ejecutamos

![ejecutado](img/ejecutado.PNG)



Mostramos la web

![web](img/web.PNG)
