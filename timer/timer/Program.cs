using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Temporizador de 10 segundos:");

        // Tiempo en segundos
        int tiempo = 10;

        // Ciclo para contar regresivamente
        while (tiempo > 0)
        {
            Console.WriteLine($"Tiempo restante: {tiempo} segundos");
            Thread.Sleep(1000); // Pausa por 1 segundo
            tiempo--;
        }

        Console.WriteLine("¡El tiempo ha terminado!");
    }
}
