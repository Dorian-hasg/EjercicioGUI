using System;
using System.IO;
using Topshelf;

namespace MiServicio
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<MiServicio>(s =>
                {
                    s.ConstructUsing(name => new MiServicio());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });

                // Configuración del servicio
                x.RunAsLocalSystem(); // Ejecutar como sistema local
                x.SetDescription("Servicio que borra un archivo cada hora");
                x.SetDisplayName("Mi Servicio");
                x.SetServiceName("MiServicio");
            });
        }
    }

    public class MiServicio
    {
        private System.Timers.Timer timer;

        public void Start()
        {
            // Crear un temporizador para ejecutar la tarea cada hora (3600000 milisegundos = 1 hora)
            timer = new System.Timers.Timer(3600000);
            timer.Elapsed += (sender, e) =>
            {
                string archivoABorrar = @"C:\temp\archivo_a_borrar.txt"; // Ajusta la ruta según sea necesario

                try
                {
                    if (File.Exists(archivoABorrar))
                    {
                        File.Delete(archivoABorrar);
                        Console.WriteLine($"Archivo borrado: {archivoABorrar}");
                    }
                    else
                    {
                        Console.WriteLine($"Archivo no encontrado: {archivoABorrar}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al borrar el archivo: {ex.Message}");
                }
            };

            timer.Start();
            Console.WriteLine("Servicio iniciado.");
        }

        public void Stop()
        {
            // Detener el temporizador cuando el servicio se detenga
            timer.Stop();
            timer.Dispose();
            Console.WriteLine("Servicio detenido.");
        }
    }
}
