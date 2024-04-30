using System;
using System.Collections.Generic;

// Clase Libro con sus atributos
public class Libro
{
    // Atributos
    public string Titulo;
    public string Autor;
    public string ISBN;
    public string Genero;
    public int NumEjemplaresDisponibles;

    // Constructor
    public Libro(string titulo, string autor, string iSBN, string genero, int numEjemplaresDisponibles)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = iSBN;
        Genero = genero;
        NumEjemplaresDisponibles = numEjemplaresDisponibles;
    }
}

// Clase Prestamo con sus atributos
public class Prestamo
{
    public DateTime FechaPrestamo;
    public DateTime FechaDevolucion;
    public Libro LibroPrestado; //atributo de tipo Libro
    public string Lector;
}

// Clase Biblioteca con sus atributos y métodos
// (agregar, buscar, prestar y devolver libro - lista libros disponibles y prestados)
public static class Biblioteca
{
    private static List<Libro> libros = new List<Libro>(); // Creo una lista con los libros disponibles
    private static List<Prestamo> prestamos = new List<Prestamo>(); // Creo una lista con los libros prestados

    // Método estático para agregar un nuevo libro a la biblioteca
    public static void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    // Método estático para buscar un libro por ISBN
    public static Libro BuscarLibroPorISBN(string isbn)
    {
        return libros.Find(libro => libro.ISBN == isbn);
    }

    // Método estático para prestar un libro
    public static void PrestarLibro(string isbn, string lector)
    {
        Libro libro = BuscarLibroPorISBN(isbn);
        if (libro != null && libro.NumEjemplaresDisponibles > 0)
        {
            libro.NumEjemplaresDisponibles--; // Resto 1 al numero de ejempletas de Libro
            Prestamo prestamo = new Prestamo // Agrego el libro a la lista de Prestamo
            {
                FechaPrestamo = DateTime.Today,
                LibroPrestado = libro,
                Lector = lector
            };
            prestamos.Add(prestamo);
            Console.WriteLine("Libro prestado exitosamente a " + lector);
        }
        else
        {
            Console.WriteLine("No se puede prestar el libro.");
        }
    }

    // Método estático para devolver un libro
    public static void DevolverLibro(string isbn)
    {
        Prestamo prestamo = prestamos.Find(p => p.LibroPrestado.ISBN == isbn); // Mapeo la lista de libros prestados buscando el isbn
        if (prestamo != null)
        {
            prestamo.LibroPrestado.NumEjemplaresDisponibles++; // Suma 1 a la cantidad de ejemplares del libro en la clase Libro
            prestamos.Remove(prestamo); // Quita el libro de la lista
            Console.WriteLine("Libro devuelto exitosamente.");
        }
        else
        {
            Console.WriteLine("No se encontró ningún préstamo para este libro.");
        }
    }

    // Método estático para mostrar la lista de libros disponibles
    public static void MostrarLibrosDisponibles()
    {
        Console.WriteLine("Lista de libros disponibles:");
        foreach (Libro libro in libros)
        {
            Console.WriteLine("   * ISBN: " + libro.ISBN + ", Título: " + libro.Titulo + ", Autor: " + libro.Autor + ", Ejemplares disponibles: " + libro.NumEjemplaresDisponibles + "\n");
        }
    }

    // Método estático para mostrar la lista de libros prestados
    public static void MostrarLibrosPrestados()
    {
        Console.WriteLine("Lista de libros prestados:");
        foreach (Prestamo prestamo in prestamos)
        {
            Console.WriteLine("   * ISBN: " + prestamo.LibroPrestado.ISBN + ", Título: " + prestamo.LibroPrestado.Titulo + ", Lector: " + prestamo.Lector + "\n");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Menú de inicio
        while (true)
        {
            Console.WriteLine("\n#### MENÚ PRINCIPAL ####:");
            Console.WriteLine("1. Agregar un nuevo libro");
            Console.WriteLine("2. Buscar un libro por ISBN");
            Console.WriteLine("3. Prestar un libro");
            Console.WriteLine("4. Devolver un libro");
            Console.WriteLine("5. Mostrar la lista de libros disponibles");
            Console.WriteLine("6. Mostrar la lista de libros prestados");
            Console.WriteLine("7. Salir");

            Console.Write("Ingrese su opción: ");
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    AgregarLibro();
                    break;
                case 2:
                    BuscarLibro();
                    break;
                case 3:
                    PrestarLibro();
                    break;
                case 4:
                    DevolverLibro();
                    break;
                case 5:
                    MostrarLibrosDisponibles();
                    break;
                case 6:
                    MostrarLibrosPrestados();
                    break;
                case 7:
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");
                    break;
            }
        }
    }

    static void AgregarLibro()
    {
        Console.WriteLine("\nAgregar un nuevo libro:");
        // Solicita al usuario que ingrese los detalles del libro
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        Console.Write("Autor: ");
        string autor = Console.ReadLine();
        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Género: ");
        string genero = Console.ReadLine();
        Console.Write("Número de ejemplares disponibles: ");
        // Asegura de que el número de ejemplares ingresado sea válido
        int numEjemplares;
        // Si el numero ingresado es texto lo convierte a int, si no es válido o es menor a 0 por defecto pone numEjemplares en 0.
        if (!int.TryParse(Console.ReadLine(), out numEjemplares) || numEjemplares < 0)
        {
            Console.WriteLine("Cantidad no válida. Se establecerá en 0.");
            numEjemplares = 0;
        }

        // Crea un nuevo objeto Libro con los detalles ingresados por el usuario
        Libro libro = new Libro(titulo, autor, isbn, genero, numEjemplares);

        // Agrega el libro a la biblioteca
        Biblioteca.AgregarLibro(libro);
        Console.WriteLine("Libro agregado exitosamente.");
    }

    static void BuscarLibro()
    {
        Console.WriteLine("\nBuscar un libro por ISBN:");
        Console.Write("Ingrese el ISBN del libro: ");
        string isbn = Console.ReadLine();
        // Busca el libro en la biblioteca por su ISBN
        Libro libro = Biblioteca.BuscarLibroPorISBN(isbn);
        if (libro != null)
        {
            // Si lo encuentra, muestra los detalles
            Console.WriteLine("Libro encontrado:");
            Console.WriteLine("Título: " + libro.Titulo);
            Console.WriteLine("Autor: " + libro.Autor);
            Console.WriteLine("Género: " + libro.Genero);
            Console.WriteLine("Número de ejemplares disponibles: " + libro.NumEjemplaresDisponibles);
        }
        else
        {
            Console.WriteLine("No se encontró ningún libro con ese ISBN.");
        }
    }

    static void PrestarLibro()
    {
        Console.WriteLine("\nPrestar un libro:");
        Console.Write("Ingrese el ISBN del libro a prestar: ");
        string isbn = Console.ReadLine();
        Console.Write("Nombre del lector: ");
        string lector = Console.ReadLine();

        Biblioteca.PrestarLibro(isbn, lector);
    }

    static void DevolverLibro()
    {
        Console.WriteLine("\nDevolver un libro:");
        Console.Write("Ingrese el ISBN del libro a devolver: ");
        string isbn = Console.ReadLine();

        Biblioteca.DevolverLibro(isbn);
    }

    static void MostrarLibrosDisponibles()
    {
        Biblioteca.MostrarLibrosDisponibles();
    }

    static void MostrarLibrosPrestados()
    {
        Biblioteca.MostrarLibrosPrestados();
    }
}