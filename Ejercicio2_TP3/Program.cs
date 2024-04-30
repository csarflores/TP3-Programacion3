using System;

public static class Matematicas
{
    // Método estático para sumar dos números enteros
    public static int Sumar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }
    // Propiedad estática para almacenar el valor de Pi
    public static double Pi = 3.14159;

    
}

class Program
{
    static void Main(string[] args)
    {
        // Crear dos variables enteras y asignarles valores
        int num1 = 10;
        int num2 = 5;

        // Llamar al método sumar() con las dos variables enteras como argumentos e imprimir el resultado
        int resultado = Matematicas.Sumar(num1, num2);
        Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + resultado);

        // Acceder a la propiedad pi e imprimir su valor
        Console.WriteLine("El valor de Pi es: " + Matematicas.Pi);
    }
}