using System;

public class Constantes
{
    // Constantes estáticas
    public const string NOMBRE_APLICACION = "MiAplicacion";
    public const string VERSION = "1.0";
    public const string RUTA_ARCHIVO_LOG = "C:\\Logs\\mi_aplicacion.log";
}

class Program
{
    static void Main(string[] args)
    {
        // Imprimir el valor de cada constante
        Console.WriteLine("Nombre de la aplicación: " + Constantes.NOMBRE_APLICACION);
        Console.WriteLine("Versión de la aplicación: " + Constantes.VERSION);
        Console.WriteLine("Ruta del archivo de registro: " + Constantes.RUTA_ARCHIVO_LOG);
    }
}