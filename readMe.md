
# Proyecto Poo

- El siguiente proyecto consta de la creacion de un videojuego en la plataforma Unity, este juego pertenece a un innovador genero que mezcla el estilo de plataformas con el combate por turnos. Actualmente, nos encontramos en la fase final de desarrollo, por lo que esta version es aun una beta de lo que sera el juego completo. El codigo fuente del programa lo puedes encontrar en el siguiente repositorio:

[Repositorio](https://github.com/Ryshadio/Proyecto-POO)


## Uso e Instalación

- Para aquellos que quieran editar este juego de codigo abierto necesitan unity en su version 2022.1.4f1, en esta aplicacion podran editar tanto las escenas como los scripts que contienen los distintos objetos presentes en el juego, posterior a eso para jugar el juego desde Unity puedes apretar el boton play que aparece en la parte superior o hacer una build para tener el archivo exe en tu escritorio. Por otro lado, si lo que quieres es solamente jugar puedes abrir el siguiente link:

[Link Descarga Juego](https://drive.google.com/file/d/1pAgQdQH_FiZLykebaLivSGt4LN2x9p_P/view?usp=sharing)

- Aquí descargarás una carpeta .zip llamada juego, deberá ser descomprimida y finalmente para ejecutar el juego se debe abrir el archivo llamado **My Proyect.exe**

## Funcionamiento del Juego

- Este es un juego de batalla por turno de un solo jugador vs el mismo programa, tiene un menú principal en donde uno puede elegir comenzar a juagr, opciones del juego (como cambiar el volumen del mismo) y la opcion de salir del juego, 

![image](https://user-images.githubusercontent.com/101778855/181620362-44a4a53b-239e-4972-8857-894322acdde2.png)

- Cuando se le de a iniciar el jugador se puede ir moviendo por la pantalla con las flechas del teclado y saltando mediante la tecla *espacio*

![image](https://user-images.githubusercontent.com/101778855/181620474-3f1c06d3-bf3d-4eaa-ade7-ba5327bce18e.png)

- si llegua a toparse con un enemigo, comienza la pelea, en la que cada contendiente se irá atacando y quitando puntos de salud a cada uno.

![image](https://user-images.githubusercontent.com/101778855/181620555-bb1b9684-f0aa-4e5f-a587-6b6c17de9efa.png)

- En esta versión del juego, cuando uno de los dos peleadores se quede sin puntos de salud el juego se cerrará automaticamente y para volver a jugar se deberá volver a abrir el archivo *My Proyect.exe* 

## Apartado Programatico

-El juego fue diseñado en unity en su version 2022.1.4f1, en lenguaje c# y el diagrama de clases utilizado fue el siguiente: 

![image](https://user-images.githubusercontent.com/101778855/181617480-35f31652-b503-4a90-948b-1411c02084e6.png)

## Orientación a Objetos.

- Este juego esta programado siguiendo al 100% la lógica de Programación Orientada a Objetos, ya que si se accede el repositorio, especialmente el apartado de [scripts](https://github.com/Ryshadio/Proyecto-POO/tree/main/Assets/Scripts),  se ejemplifica el uso de esta lógica  si abrimos el archivo [Battlesystem](https://github.com/Ryshadio/Proyecto-POO/blob/main/Assets/Scripts/BattleSystem.cs), donde existen objetos de las clases BattleEnemy y BattlePlayer. Esta interacción entre objetos de distintas clases permite el correcto funcionamiento del programa.

### Integrantes

- Tabata Ahumada        202030514-5
- Rodrigo Contreras     202010519-7
- Diego Flores          202004542-9
- Álvaro Pozo           202030535-8
- Leonardo Ponce        202030531-5
