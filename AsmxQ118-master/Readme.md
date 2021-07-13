## Ejemplo de llamar un AJAX desde Javascript a un clasico ASMX 

Esto implementa un escenario donde tenemos una web que consume un servicio web. proporciona tipos de cambio de moneda. Los visitantes ingresan el
tipo de moneda en la página web y presionan el botón Enviar.
El servicio web devuelve el tipo de cambio actual. Debe asegurarse de que la página web siempre muestre la información más actualizada.
        
**¿Cómo debe completar el código relevante?**

**Resumen:**

Aqui lo relevante es la llamada de $ajax(), no confundir con $getJSON() que es otra alternativa. En el escenario presentado se simula un tipo de contenido JSON pero en realidad es Text/Plain de entrada al WebService El webservice devuelve un string JSON 

La implantación en el JavaScript es $ajax() y la cache se desabilita para asegurarse que la página web siempre muestre la informacion mas actualizada.

Referencia: **Question 118**

Puntos en el clasico ASMX:

####  WebConfig.config
Lineas 11 se inserta este contenido para habilitar los metodos POST y GET:

```xml
<webServices>
   <protocols>
      <add name="HttpPost"/>
      <add name="HttpGet"/>
   </protocols>
</webServices>
```

#### CurrencyConverter.amxm.cs

Linea 19 insertamos el siguiente atributo:
```c#
    [System.Web.Script.Services.ScriptService]
```

Linea 25 el WebMothod se cambia a tipos VOID

Linea 44 Se implementa una lista generica para gestion del JSON mas adelante

Linea 52 Se implementa la respuesta con la serialización del objeto JSON a string
```c#
Context.Response.Write(js.Serialize(response));
```