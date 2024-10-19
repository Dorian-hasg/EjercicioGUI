using System;

namespace ConceptosBasicosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de operadores aritméticos
            int a = 10;
            int b = 3;

            // Expresión: combinación de operandos y operadores
            int suma = a + b;        // Operador suma
            int resta = a - b;       // Operador resta
            int multiplicacion = a * b; // Operador multiplicación
            double division = (double)a / b;  // Operador división, se hace casting para obtener resultado decimal
            int modulo = a % b;      // Operador módulo (resto de la división)

            Console.WriteLine("Operadores Aritméticos:");
            Console.WriteLine($"Suma: {a} + {b} = {suma}");
            Console.WriteLine($"Resta: {a} - {b} = {resta}");
            Console.WriteLine($"Multiplicación: {a} * {b} = {multiplicacion}");
            Console.WriteLine($"División: {a} / {b} = {division}");
            Console.WriteLine($"Módulo: {a} % {b} = {modulo}");

            // Ejemplo de operadores relacionales
            Console.WriteLine("\nOperadores Relacionales:");
            Console.WriteLine($"{a} > {b}: {a > b}");  // Mayor que
            Console.WriteLine($"{a} < {b}: {a < b}");  // Menor que
            Console.WriteLine($"{a} == {b}: {a == b}"); // Igualdad
            Console.WriteLine($"{a} != {b}: {a != b}"); // Desigualdad

            // Ejemplo de operadores lógicos
            bool esMayor = a > b;
            bool esIgual = a == b;

            Console.WriteLine("\nOperadores Lógicos:");
            Console.WriteLine($"esMayor AND esIgual: {esMayor && esIgual}"); // AND lógico
            Console.WriteLine($"esMayor OR esIgual: {esMayor || esIgual}");  // OR lógico
            Console.WriteLine($"NOT esMayor: {!esMayor}");                   // NOT lógico

            // Instrucción condicional (if-else) basada en expresiones
            Console.WriteLine("\nCondicional if-else:");
            if (a > b)
            {
                Console.WriteLine($"{a} es mayor que {b}");
            }
            else
            {
                Console.WriteLine($"{a} no es mayor que {b}");
            }

            // Bucle con operadores de asignación
            Console.WriteLine("\nBucle con operador de incremento:");
            int contador = 0;
            while (contador < 5) // Expresión condicional
            {
                Console.WriteLine($"Contador: {contador}");
                contador++; // Operador de incremento
            }
        }
    }
}
