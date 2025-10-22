using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HistogramaEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de personas: ");
            int n = int.Parse(Console.ReadLine());

            int[] edades = GenerarEdades(n);
            MostrarHistograma(edades);
            Console.WriteLine($"\nEdad mayor: {EdadMayor(edades)}");
            Console.WriteLine($"Promedio de edades: {Promedio(edades):0.00}");
        }

        // Genera edades aleatorias entre 5 y 30
        static int[] GenerarEdades(int n)
        {
            Random rnd = new Random();
            int[] edades = new int[n];

            for (int i = 0; i < n; i++)
                edades[i] = rnd.Next(5, 31); // 31 es exclusivo

            return edades;
        }

        // Muestra el histograma con barras de '*'
        static void MostrarHistograma(int[] edades)
        {
            Console.WriteLine("\nHistograma de edades:");
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine($"Persona {i + 1,2}: {edades[i],2} | {new string('*', edades[i] / 2)}");
            }
        }

        // Devuelve la edad mayor
        static int EdadMayor(int[] edades)
        {
            int mayor = edades[0];
            foreach (int edad in edades)
                if (edad > mayor)
                    mayor = edad;
            return mayor;
        }

        // Calcula el promedio
        static double Promedio(int[] edades)
        {
            double suma = 0;
            foreach (int edad in edades)
                suma += edad;
            return suma / edades.Length;
        }
    }
}

