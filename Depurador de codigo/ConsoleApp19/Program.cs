using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario el primer número
        Console.WriteLine("Introduce el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Pedir al usuario el segundo número
        Console.WriteLine("Introduce el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Sumar los dos números
        double suma = num1 + num2;

        // Mostrar el resultado
        Console.WriteLine("La suma de los dos números es: " + suma);
    }
}