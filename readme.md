# TRABAJO PRÁCTICO N° 3
## Programación 3 - TUP - UTN Rafaela - 2024

## ALUMNO
 - César Flores

## EJERCICIOS SOBRE MIEMBROS ESTÁTICOS Y NO ESTÁTICOS EN C#

### 1 Creación de una clase con miembros estáticos y no estáticos:
- Se crea la clase Estudiante con los siguientes atributos:
    - `nombre`: Cadena de texto que almacena el nombre del estudiante.
    - `apellido`: Cadena de texto que almacena el apellido del estudiante.
    - `edad`: Entero que almacena la edad del estudiante.
    - `añoIngreso`: Entero que almacena el año de ingreso del estudiante.
- La clase debe tener un constructor no estático que inicialice todos los atributos.
- La clase debe tener un método estático llamado calcularPromedioEdad() que calcule y devuelva el promedio de edad de todos los estudiantes creados.
- Crear dos objetos Estudiante e inicializar sus atributos.
- Imprimir el nombre, apellido, edad y año de ingreso de cada estudiante.
- Llamar al método calcularPromedioEdad() e imprimir el promedio de edad.

### 2 Creación de una clase estática con métodos y propiedades estáticos:
- Crear una clase estática llamada Matematicas.
- La clase debe tener un método estático llamado sumar(int numero1, int numero2) que sume dos números enteros y devuelva el resultado.
- La clase debe tener una propiedad estática llamada pi que almacene el valor de pi (3.14159).
- Crear dos variables enteras y asignarles valores.
- Llamar al método sumar() con las dos variables enteras como argumentos e imprimir el resultado.
- Acceder a la propiedad pi e imprimir su valor.

### 3 Utilización de miembros estáticos para constantes:
- Crear una clase llamada Constantes.
- La clase debe tener las siguientes constantes estáticas:
- NOMBRE_APLICACION: Cadena de texto que almacena el nombre de la aplicación.
- VERSION: Cadena de texto que almacena la versión de la aplicación.
- RUTA_ARCHIVO_LOG: Cadena de texto que almacena la ruta del archivo de registro.
- Imprimir el valor de cada constante.

### 4 Ejercicio práctico:
Crear una aplicación para gestionar una biblioteca.
La aplicación debe tener las siguientes clases:
    - Libro: La clase Libro debe tener atributos como título, autor, ISBN, género y número de ejemplares disponibles.
    - Prestamo: La clase Prestamo debe tener atributos como fecha de préstamo, fecha de devolución, libro prestado y lector que lo ha prestado.

La clase Biblioteca debe tener los siguientes miembros:
    - Un método estático para agregar un nuevo libro a la biblioteca.
    - Un método estático para buscar un libro por ISBN.
    - Un método estático para prestar un libro.
    - Un método estático para devolver un libro.
    - Un método estático para mostrar la lista de libros disponibles.
    - Un método estático para mostrar la lista de libros prestados.

La aplicación debe tener un menú principal que permita al usuario realizar las siguientes acciones:
    - Agregar un nuevo libro.
    - Buscar un libro por ISBN.
    - Prestar un libro.
    - Devolver un libro.
    - Mostrar la lista de libros disponibles.
    - Mostrar la lista de libros prestados.

Los miembros estáticos de la clase Biblioteca deben usarse para gestionar la información de los libros y préstamos. 