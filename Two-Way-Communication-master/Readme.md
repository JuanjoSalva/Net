## Two-Way Communication

En esta demostración, primero verá cómo configurar SignalR en una aplicación ASP.NET Core. Después de eso, verá cómo agregar un concentrador SignalR a la aplicación. Luego verá cómo conectarse al concentrador desde el código del lado del cliente.

A veces es necesario llamar a métodos en clientes específicos. Por ejemplo, en un sitio web de chat, generalmente hay varias salas de chat, y los usuarios se unen a salas de chat específicas y reciben mensajes solo para esa sala específica. Además, deberá identificar los casos en los que los usuarios salen de la sala de chat para que dejen de recibir mensajes.

Esto se puede administrar mediante la propiedad Context de la clase de concentrador. La propiedad Context es del tipo HubCallerContext y se puede usar para identificar al usuario que realizó la llamada. Además, al anular los métodos OnConnectedAsync y OnDisconnectedAsync en el concentrador, puede realizar operaciones iniciales y finales en los clientes, lo que le permite agregar o eliminar de grupos o eliminar clientes para que no se muestren.

Otra propiedad útil del concentrador es la propiedad Grupos. Esta propiedad es del tipo IGroupManager y expone los métodos AddToGroupAsync y RemoveFromGroupAsync. Ambos métodos reciben un ID de conexión y un grupo al que se agregará o eliminará la conexión, respectivamente. El ID de conexión se puede encontrar utilizando la propiedad ConnectionId en la propiedad Context. Tenga en cuenta que si un cliente se desconecta, el ID de conexión se eliminará de todos los grupos automáticamente.

En este ejemplo, puede ver cómo se administra una sala de chat. Cada usuario que se une también se agrega al diccionario administrado por el concentrador y cada vez que los usuarios activos cambian, todos los usuarios registrados reciben una lista actualizada de todos los usuarios conectados.


En nuestro ejemplo se crea un tablero con una matriz de 3 x 3 botones. Se abren varias ventanas y cuando se pulsa sobre un botón se cambia de color y se replica en el resto de clientes.

Inicio, abro 2 ventanas:
![inicio](https://github.com/JuanjoSalva/Two-Way-Communication/blob/master/SignalRExample/img/inicio.PNG)

Pulso sobre un botón del ventana de la izquierda y veo si se replica en la otra:
![inicio](https://github.com/JuanjoSalva/Two-Way-Communication/blob/master/SignalRExample/img/pulso_izq.PNG)

Pulso sobre un botón del ventana de la derecha y veo si se replica en la otra:
![inicio](https://github.com/JuanjoSalva/Two-Way-Communication/blob/master/SignalRExample/img/pulso_drch.PNG)
