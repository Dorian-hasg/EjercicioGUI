using System;
using System.Collections.Generic;

namespace AppDelegado
{
    class Libro
    {
        public string Titulo { get; }
        public string Autor { get; }
        public decimal PrecioTotal { get; }
        public bool TienePortadaPapel { get; }

        public Libro(string titulo, string autor, decimal precioTotal, bool tienePortadaPapel)
        {
            Titulo = titulo;
            Autor = autor;
            PrecioTotal = precioTotal;
            TienePortadaPapel = tienePortadaPapel;
        }
    }

    class LibroDB
    {
        private List<Libro> libros = new List<Libro>();

        public void AddLibro(Libro libro)
        {
            libros.Add(libro);
        }

        // Método que procesa libros con portada de papel usando un delegado Action
        public void ProcesarPortada(Action<Libro> proceso)
        {
            foreach (Libro libro in libros)
            {
                if (libro.TienePortadaPapel)
                {
                    proceso(libro);
                }
            }
        }

        // Método que usa un Func para procesar el total de libros con portada de papel
        public decimal ProcesarPortada(Func<decimal, Libro, decimal> totalizador, decimal totalInicial)
        {
            decimal total = totalInicial;

            foreach (Libro libro in libros)
            {
                if (libro.TienePortadaPapel)
                {
                    total = totalizador(total, libro);
                }
            }

            return total;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LibroDB libroLista = new LibroDB();
            AddLibros(libroLista);

            Console.WriteLine("Títulos de libros con portada de papel:");
            libroLista.ProcesarPortada(ImprimirTitulo);

            decimal totalLibros = libroLista.ProcesarPortada(CalcularTotal, 0);
            Console.WriteLine($"El precio de todos los libros de portada de papel es: {totalLibros:C}");

            Console.ReadKey();
        }

        // Método que imprime el título de un libro
        static void ImprimirTitulo(Libro lb)
        {
            Console.WriteLine(lb.Titulo);
        }

        // Método que calcula el total de los precios de los libros
        static decimal CalcularTotal(decimal total, Libro lb)
        {
            return total + lb.PrecioTotal;
        }

        // Método que añade libros a la base de datos
        static void AddLibros(LibroDB libroDB)
        {
            libroDB.AddLibro(new Libro("The C Programming Language", "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true));
            libroDB.AddLibro(new Libro("The Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true));
            libroDB.AddLibro(new Libro("The MS-DOS Encyclopedia", "Ray Duncan", 129.95m, false));
            libroDB.AddLibro(new Libro("Dogbert's Clues for the Clueless", "Scott Adams", 12.00m, true));
        }
    }
}
