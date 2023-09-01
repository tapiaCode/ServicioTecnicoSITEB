# Sistema de Control y Registro de Inventario
***

Este sistema es una herramienta que ayuda a las empresas de servicio técnico y venta de accesorios para computadoras a administrar sus inventarios, clientes y servicios. El sistema permite a las empresas realizar un seguimiento de sus productos, sus niveles de inventario, sus ventas y sus clientes. También permite a las empresas gestionar sus servicios técnicos, incluyendo el seguimiento de las citas, las tareas y los problemas.

Características

- Administración de inventario: El sistema permite a las empresas realizar un seguimiento de sus productos, sus niveles de inventario, sus ventas y sus clientes.
- Gestión de clientes: El sistema permite a las empresas gestionar sus clientes, incluyendo su información de contacto, sus pedidos y sus servicios técnicos.
- Gestión de servicios técnicos: El sistema permite a las empresas gestionar sus servicios técnicos, incluyendo el seguimiento de las citas, las tareas y los problemas.
- Informes: El sistema genera informes que pueden ayudar a las empresas a tomar mejores decisiones sobre sus negocios.
Beneficios

- El sistema ayuda a las empresas a ahorrar tiempo y dinero.
- El sistema ayuda a las empresas a mejorar su servicio al cliente.
- El sistema ayuda a las empresas a aumentar sus ventas.
- El sistema ayuda a las empresas a tomar mejores decisiones sobre sus negocios.

¿Cómo empezar?

Para empezar a usar el sistema, descarga o clona el código del repositorio de GitHub. Luego, actuliza las librerias y continua con los siguientes pasos.

primero deberas clonar de forma local la base de datos con todos los metodos correspondientes.

para ello puedes descargar el backup del sgte enlace [BACKUP DATABASE]([enlacependiente.com](https://drive.google.com/file/d/1QSLSo1Lu0sNoe36MGaq3xWBvvF1njgbk/view?usp=drive_link)

luego deberas establecer la conexion a la base de datos de manera local selecciona el app.config la capa de datos y elimina la cadena de conexion para luego agregar tu propia cadena local de forma manual, o mediante ADONET. que es un elemento nativo de .NET
```
/ServicioTecnicoSITEB.Datos/app.config

<connectionStrings>
    <add name="DBSITEPEntities" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=TAPIA-PC\SQLEXPRESS;initial catalog=DBSITEP;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
```
## PARA HACERLO DE MANERA MANUAL 
primero elimina el model en la capa de datos 
![Alt text](/img//1.png?raw=true "PASO 1")

Fuente: https://www.iteramos.com/pregunta/7578/como-anadir-capturas-de-pantalla-a-los-readmes-en-el-repositorio-de-github



Recursos

- El repositorio de GitHub contiene el código del sistema.

¡Gracias por usar el Sistema de Control y Registro de Inventario!

Integrantes :
- Jose Manuel Tapia Martinez
- Samuel Jeronimo Machuca Videz
- Ronald Brayan Cusiquispe Paco
- Jhon Beimar Cruz Montaño

UNIVERSIDAD PRIVADA DOMINGO SAVIO
SISTEMAS DE INFORMACION III

