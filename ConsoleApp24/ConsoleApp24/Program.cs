using System; // Para las funciones básicas del sistema (como Console y excepciones)
using System.IO; // Para trabajar con archivos y directorios
using System.Collections.Generic; // Para el uso de colecciones genéricas
using System.Text; // Para manipulación de cadenas y codificación

namespace EjemploEspaciosNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso de System.IO para crear y escribir en un archivo
            string filePath = @"C:\temp\miArchivo.txt";

            try
            {
                // Verificar si el directorio existe, si no, crear el directorio
                if (!Directory.Exists(@"C:\temp"))
                {
                    Directory.CreateDirectory(@"C:\temp");
                }

                // Crear y escribir en el archivo
                File.WriteAllText(filePath, "Hola, este es un archivo de ejemplo.\n");

                // Leer y mostrar el contenido del archivo
                string contenido = File.ReadAllText(filePath);
                Console.WriteLine("Contenido del archivo:");
                Console.WriteLine(contenido);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Ejemplo de uso de System.Collections.Generic para trabajar con listas genéricas
            List<string> listaDeNombres = new List<string> { "Ana", "Carlos", "María", "Juan" };
            listaDeNombres.Add("Pedro"); // Añadir un nuevo nombre a la lista

            Console.WriteLine("\nLista de nombres:");
            foreach (var nombre in listaDeNombres)
            {
                Console.WriteLine(nombre);
            }

            // Ejemplo de uso de System.Text para manipulación de cadenas
            StringBuilder sb = new StringBuilder();
            sb.Append("Esta es una cadena creada con StringBuilder. ");
            sb.Append("Es útil para la concatenación eficiente de cadenas.");

            Console.WriteLine("\nContenido de StringBuilder:");
            Console.WriteLine(sb.ToString());
        }
    }
}
