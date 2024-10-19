using System;

namespace OperacionesVectores
{
    interface IOperaciones
    {
        double[] Suma(double[] a, double[] b);
        double[] Resta(double[] a, double[] b);
        double[] Multiplicacion(double[] a, double[] b);
        double[] Division(double[] a, double[] b);
    }

    class Operaciones : IOperaciones
    {
        public double[] Suma(double[] a, double[] b)
        {
            double[] resultado = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                resultado[i] = a[i] + b[i];
            }
            return resultado;
        }

        public double[] Resta(double[] a, double[] b)
        {
            double[] resultado = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                resultado[i] = a[i] - b[i];
            }
            return resultado;
        }

        public double[] Multiplicacion(double[] a, double[] b)
        {
            double[] resultado = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                resultado[i] = a[i] * b[i];
            }
            return resultado;
        }

        public double[] Division(double[] a, double[] b)
        {
            double[] resultado = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (b[i] != 0)
                {
                    resultado[i] = a[i] / b[i];
                }
                else
                {
                    resultado[i] = double.NaN; // Para evitar división por cero
                }
            }
            return resultado;
        }
    }

    delegate double[] OperacionDelegate(double[] a, double[] b);

    class Program
    {
        static double[] Apply(OperacionDelegate operacion, double[] a, double[] b)
        {
            return operacion(a, b);
        }

        static void Main(string[] args)
        {
            double[] vector1 = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            double[] vector2 = { 5.0, 4.0, 3.0, 2.0, 1.0 };

            Operaciones operaciones = new Operaciones();

            double[] suma = Apply(operaciones.Suma, vector1, vector2);
            double[] resta = Apply(operaciones.Resta, vector1, vector2);
            double[] multiplicacion = Apply(operaciones.Multiplicacion, vector1, vector2);
            double[] division = Apply(operaciones.Division, vector1, vector2);

            Console.WriteLine("Suma: " + string.Join(", ", suma));
            Console.WriteLine("Resta: " + string.Join(", ", resta));
            Console.WriteLine("Multiplicación: " + string.Join(", ", multiplicacion));
            Console.WriteLine("División: " + string.Join(", ", division));
        }
    }
}
