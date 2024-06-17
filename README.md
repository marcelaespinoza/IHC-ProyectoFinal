# Handball VR
Proyecto final del curso de Interacción Humano Computador

Integrantes:
- Marcela Espinoza
- Hans Mendoza
- Jose Wong

## Antecedentes

Actualmente, las tecnologías XR (Realidad Extendida) se están utilizando en distintas áreas, y una de ellas ha sido el deporte. En 2023, un estudio titulado "Implementation of virtual reality technology for sports education and training: Systematic literature review" publicado en la conferencia Internacional de Ciencias de la Computación y la Inteligencia Computacional, revisa el estado actual de las aplicaciones de realidad virtual en la educación y entrenamiento deportivo. Este estudio, analiza cómo la realidad virtual (VR) ha sido implementada en diversos deportes para mejorar el entrenamiento y la educación deportiva. Para ello realizó una búsqueda sistemática en bases de datos científicas, evaluando investigaciones entre 2010 y 2022, y seleccionó 30 artículos relevantes de un total de 995 encontrados. Los resultados indican un patrón creciente en el uso de VR en el deporte, y concluye que la VR puede mejorar significativamente el rendimiento deportivo al proporcionar un entorno de entrenamiento interactivo y controlado, lo que permite a los atletas entrenar en cualquier momento y lugar.

Adicional a ello, otro estudio titulado "The Effect of Using Virtual Reality Technology, VR BOX Glasses, on Learning the Skill of Shooting in Handball" publicado en la Revista Iberoamericana de Psicología del Ejercicio y el Deporte, investigó el efecto del uso de la tecnología de realidad virtual, específicamente las gafas VR BOX, en el aprendizaje de la habilidad de tiro en balonmano. La metodología del estudio incluyó a 30 estudiantes de la Universidad de Mutah, divididos en dos grupos: el grupo experimental, que utilizó VR BOX para aprender la habilidad de tiro durante seis semanas, y el grupo de control, que utilizó métodos tradicionales durante el mismo periodo. Los resultados demostraron que el uso de VR BOX contribuyó positivamente al aprendizaje de la habilidad de tiro, superando en efectividad al método tradicional.

## Requisitos de diseño y persona

### Requisitos funcionales

Tabla de requisitos

La definición de estos requerimientos funcionales se realizó a partir de las principales preocupaciones que enfrentan deportistas al prácticar balónmano, estas fueron: 
- Falta de espacios para practicar balónmano
- Pérdida de tiempo por tener que trasladarse de un lugar a otro para poder prácticar
- Necesidad de contar con otra persona para poder prácticar, ya sea como entrenador o lanzador.
- Dificultad para encontrar una persona al mismo nivel deportivo del que practica

Las dos primeras preocupaciones se resuelven de manera general con la construcción de este proyecto; y está conectada con los requisitos RF01, RF02 y RF07, que refieren a las mecánicas principales del juego que el usuario puede realizar. De manera particular y abordando la tercera problemática, los requerimientos RF03 y RF04 se refieren a los modos de juego que permiten al usuario poder prácticar sin la necesidad de compañia y de manera optimizada. Luego, el requerimiento RF05, RF06 y RF07 brinda al usuario la libertad de poder personalizar su práctica de penales. Finalmente, el requisito RF08 se refiere al modo de juego de una serie completa contra la máquina.

### Requisitos no funcionales

Tabla de requisitos

Los requisitos RNF01 y RNF02 se refieren al desarrollo de la aplicación y en las plataformas en la que se ejecutará. Mientras que el requesito RNF03 fue decidido para poder llegar a un público internacional.

### Audiencia

Jugadores de balonmano y personas interesadas en el deporte. Los roles que pueden tomar son los los siguientes:
- Lanzador de penal de balonmano
- Arquero de penal de balonmano

### Especificación final del usuario

Personas en un rango de 15 a 35 años que conozcan el deporte de balónmano y quieran perfeccionar su técnica pero no cuenten con el espacio o dinero para poder hacerlo en una cancha.

### Objetivo de la experiencia

Brindarle al usuario una simulación de lanzamiento de penales de balonmano en un entorno de realidad virtual, y que les sirva para mejorar su técnica de lanzamiento o tapado de estos.

### Narrativa de la aplicación

Eres un jugador de un equipo pequeño de balónmano que busca ser el mejor lanzador de penales/
arquero del equipo, para poder asegurar la victoria durante estos momentos de infarto en un partido. Por esto, entras a un entorno de realidad virtual donde podrás perfeccionar tu técnica, precisión y reflejo.s. Aquí podras tirar o tapar cuanto penales quieras, configurando los parámetros que prefieras para hacer de ti un mejor jugador de balónmano. Finalmente,  puedes poner a prueba lo practicado en una serie de penales contra la máquina, saliendo de tu sesión con la app más preparado para la siguiente tanda de penales que decidan un título.

### Arco de la historia

https://miro.com/welcomeonboard/RUg2SFNRQ1NVQnBFR0NWSVZLMWlMbVNweUFueEVYOW5rc3kxYlI5bEFBQmxZOVVtTGVMWDJJSkR6aHJvOVdGWXwzNDU4NzY0NTE1MjgwNjE0MDI3fDI=?share_link_id=400328886097

### Métrica HEART

Tabla de metricas

## Framework de diseño

### Descripción del framework

Para el diseño de nuestra aplicación de entrenamiento de balonmano en realidad virtual (VR), hemos priorizado la inmersión y la interacción intuitiva. La aplicación ofrece tres modos de práctica: "Striker", "Defend" y "Play Match" (detallados más abajo). En todos los modos, se lleva un registro del puntaje y el tiempo de entrenamiento. Además, el usuario puede pausar el juego realizando la señal de pulgar arriba.

Hemos diseñado la aplicación para ser compatible con los visores Meta Quest 2, asegurando una experiencia de VR optimizada. La previsibilidad se logra a través de una interfaz intuitiva y consistente, donde los controles son fácilmente accesibles y las funciones están claramente visibles. La flexibilidad se manifiesta en la capacidad del usuario para personalizar parámetros de entrenamiento y pausar el juego según sus necesidades. La simplicidad y la memorización son facilitadas por un diseño minimalista y coherente, permitiendo a los usuarios concentrarse en su entrenamiento sin distracciones. La personalización de la dificultad, ajustando parámetros como la velocidad y la dirección de las pelotas, permitirá una inmersión más profunda al usuario, aumentando la emoción y el desafío durante el entrenamiento.

Los principios de compatibilidad y flexibilidad se reflejan en la capacidad del usuario para personalizar su entrenamiento y pausar el juego cuando sea necesario. La previsibilidad se asegura mediante una interfaz intuitiva, donde las acciones y resultados son claramente anticipados. La presencia profunda se logra a través de una interfaz interactiva y efectos de sonido envolventes, proporcionando una experiencia inmersiva y efectiva.

### Áreas de entrenamiento

- Striker: El usuario practica lanzamientos de penales con un límite de tiempo de 3 segundos por lanzamiento y otras restricciones propias del juego.
- Defend: El usuario practica bloqueos de penales, pudiendo programar la velocidad, intervalos y dirección de las pelotas.
- Play match: El usuario puede jugar partidos completos contra la computadora, alternando entre ser "Striker" y "Defend", compitiendo hasta alcanzar un límite de puntos para determinar al ganador.

### Plan de diseño

Los usuarios pueden seleccionar y personalizar sus entrenamientos, ajustando la velocidad y dirección de las pelotas, y competir en partidos simulados contra la computadora. Los límites técnicos de la experiencia incluyen la necesidad de familiarización con el visor VR y la optimización del espacio físico para evitar obstáculos. A pesar de estos límites, la aplicación proporciona una presencia profunda, haciendo que los usuarios se sientan como verdaderos jugadores de balonmano. La música de fondo adecuada y los efectos de sonido mejoran la inmersión, mientras que la interacción intuitiva y la libertad en la personalización del entrenamiento aseguran una experiencia de usuario satisfactoria.

## Prototipo

Para tener una idea inicial del diseño de la aplicación, se ha elaborado un prototipo de baja fidelidad en Figma.
