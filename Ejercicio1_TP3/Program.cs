using System;

public class Estudiante
{
    // Atributos
    public string nombre;
    public string apellido;
    public int edad;
    public int anioIngreso;
    private static int totalEdad = 0;
    private static int totalEstudiantes = 0;

    // Constructor
    public Estudiante(string nombre, string apellido, int edad, int anioIngreso)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.anioIngreso = anioIngreso;
        totalEdad += edad; // suma las edades de todos los objetos estudiantes ingresados
        totalEstudiantes++; // cuenta todos los estudiantes ingresados
    }

    // Método para calcular el promedio de edad
    public static double CalcularPromedioEdad()
    {
        return (double)totalEdad / totalEstudiantes;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista para almacenar objetos Estudiante
        var estudiantes = new List<Estudiante>();

        char salir = 's';
        while (salir == 's' || salir == 'S')
        {            
            Console.WriteLine("Ingrese los datos del estudiante:");
            // Solicita al usuario que ingrese los detalles del estudiante
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Año ingreso: ");
            int anioIngreso = Convert.ToInt32(Console.ReadLine());

            // Crea un nuevo objeto Estudiante
            Estudiante estudiante = new Estudiante(nombre, apellido, edad, anioIngreso);

            // Agrega el estudiante a la lista
            estudiantes.Add(estudiante);

            Console.WriteLine("¿Desea agregar otro estudiante? (s/n):");
            salir = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");
        }

        // Imprimir los detalles de cada estudiante
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine("Detalles del Estudiante:");
            Console.WriteLine("  Nombre: " + estudiante.nombre);
            Console.WriteLine("  Apellido: " + estudiante.apellido);
            Console.WriteLine("  Edad: " + estudiante.edad);
            Console.WriteLine("  Año de Ingreso: " + estudiante.anioIngreso);
            Console.WriteLine();
        }

        // Calcular y mostrar el promedio de edad de todos los estudiantes
        Console.WriteLine("Promedio de Edad de todos los estudiantes: " + Estudiante.CalcularPromedioEdad());
    }
}