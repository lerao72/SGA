# SGA

SGA es un sistema de Gestión para empresas. Para darle algo de polivalencia, permite funcionar tanto con una base de datos de Access o con SQL Server (basándose en la funcionalidad que proporciona la librería LT48.dll cuyo proyecto puede verse en otro de mis repositorios (https://github.com/lerao72/LT48).

Es un proyecto en el que estuve trabajando un par de meses el 2020, la temporada que la empresa para la que trabajaba hizo un ERTE.

Mi idea era que pudieran generarse bases de datos anuales (o de otro tipo), proporcionando algún tipo de herramienta que permitiera cargar la aplicación con los distintos datos, no obstante, tras retomar el trabajo este proyecto quedó parado y no profundicé en ese tema.

No obstante, si se trabaja con SQL Server, ahí si se podría trabajar con varias BD distintas aprovechando la herramienta SGA_SQLS_Tool (en el repertorio https://github.com/lerao72/SGA_SQLS_Tool), la cual nos permite crear distintas BD. Dicha herramienta nos permite crear un archivo server.cfg el cual, colocado en la carpeta de ejecución de la aplicación SGA, permitiría conectar a la BD con las credenciales que ahí se indiquen (perdón por no encriptar el contenido del archivo... otra cosa a tareas pendientes... junto con algún sistema para poder hacer esto de forma automática y no cambiando el archivo).

La carpeta "Archivos para carpeta de ejecución" contiene una serie de archivos que deben colocarse como se indica en la carpeta de ejecución, en especial base.mdb que es el archivo que se utiliza como base para montar la BD de la aplicación para Access. Logo conforma una imagen que actúa como cabecera para facturas, albaranes, etc, de modo que podría cambiarse el contenido para adecuarlo a otra empresa. Logo_ori.jpg... bueno, creo que este fue el diseño original del logo y se quedó ahí...

UNA LEVE EXPLICACIÓN DE LAS LAS CARPETAS

BC - Base Clases... Bueno aquellas clases que representan las distintas entidades que maneja el programa. El código ha sigo generado básicamente por una aplicación que desarrollé (y que trataré de rehacer luego para adaptar a las cosas que estoy metiendo por aquí) y que dados un nombre de tabla, un nombre de clase, los campos de la BD y poco más generaba toda la retahíla de funciones para manejar dichas clases y guardarlas/recuperarlas de la base de datos (vamos, algo así como un Entity Framework casero... ¡pero muy resultón! (aunque sin generar las tablas en la BD... eso hay que hacerlo a mano... o bueno, como luego se verá a través de esta aplicación y unos cuantos comandos SQL de los de toda la vida))

MCC - Módulo: Contact class: Pantallas para gestionar los contactos, clientes, proveedores...

MAC - Módulo: Article Class: Pantallas para gestionar artículos

MBC - Módulo: Business class: Pantallas para albaranes, facturas...

MVC - Módulo: Various class: Ese cajón desastre para ir metiendo cosas que hacen... ¿cosas?

SGA - Pues eso... un anillo para controlarlos a todos. Las carpetas (módulos) MCC, MAC, MBC y MVC contienen cada una una clase llamada Comun que contiene una variable estática llamada Activo que indica si la funcionalidad de ese módulo va a estar activa (un modo de hacer distribuciones en las que se omitan funcionalidades). Basada en esta variable, se mostrarán más o menos botones en el Formulario de la aplicación principal. Que la variable esté activa provocará que además se generen las tablas en la base de datos (mirar el procedimiento SGA.FormPrincipal.actualizarBD()... si ahí se llaman a procedimientos que crean las tablas (o las actualizan dependiendo de si hemos seguido trasteando por aquí y necesitabamos nuevos campos u otros más grandes...))



PS: SGA viene de sistema de gestión... la A no recuerdo para que la puse ¿andaluz? ¿ampliable?