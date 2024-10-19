using System;

namespace AppValorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ArregloNumeros arreglo = new ArregloNumeros();
            Console.WriteLine($"Secuencia Original: {arreglo.Cadena()}");

            // Buscamos el número 63 y lo referenciamos para modificar su valor
            ref int numero = ref arreglo.BuscaNumero(63);
            numero *= 2; // Multiplicamos el valor por 2

            Console.WriteLine($"Nueva secuencia: {arreglo.Cadena()}");
        }
    }

    class ArregloNumeros
    {
        private int[] numeros = { 1, 3, 5, 15, 31, 63, 127, 255, 511, 1023 };

        // Método que busca un número y retorna una referencia al elemento
        public ref int BuscaNumero(int objetivo)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == objetivo)
                {
                    return ref numeros[i]; // Retornamos la referencia al número
                }
            }

            throw new IndexOutOfRangeException("Número no encontrado"); // Excepción si no se encuentra
        }

        // Método que devuelve la secuencia como cadena
        public string Cadena()
        {
            return string.Join(", ", numeros);
        }
    }
}
