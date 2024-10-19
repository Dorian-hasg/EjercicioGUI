using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Galaxias cercanas a la Vía Láctea!");

        // Creamos una lista de objetos Galaxia
        List<Galaxia> galaxias = new List<Galaxia>
        {
            new Galaxia { Nombre = "Cartwheel", Tipo = TipoGalaxia.Lenticular },
            new Galaxia { Nombre = "Andromeda", Tipo = TipoGalaxia.Espiral },
            new Galaxia { Nombre = "Waffei 1", Tipo = TipoGalaxia.Elíptica }
        };

        // Iteramos sobre la lista y mostramos los datos de cada galaxia
        foreach (var galaxia in galaxias)
        {
            Console.WriteLine($"{galaxia.Nombre}, {galaxia.Tipo}");
        }
    }
}

// Definimos la enumeración TipoGalaxia fuera del método
enum TipoGalaxia { Lenticular, Espiral, Elíptica }

// Definimos la clase Galaxia
class Galaxia
{
    public string Nombre { get; set; }
    public TipoGalaxia Tipo { get; set; }
}
