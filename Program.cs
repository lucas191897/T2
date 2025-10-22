using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BibliotecaVirtual
{
    // Clase que representa un libro
    class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Año { get; set; }

        public Libro(string titulo, string autor, int año)
        {
            Titulo = titulo;
            Autor = autor;
            Año = año;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | Año: {Año}");
        }
    }

    // Clase principal
    class Program
    {
        static List<Libro> biblioteca = new List<Libro>();

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n=== BIBLIOTECA VIRTUAL ===");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Mostrar todos los libros");
                Console.WriteLine("3. Buscar por autor");
                Console.WriteLine("4. Salir");
                Console.Write("Elija una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarLibro();
                        break;
                    case 2:
                        MostrarLibros();
                        break;
                    case 3:
                        BuscarPorAutor();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 4);
        }

        // Función para agregar libros
        static void AgregarLibro()
        {
            Console.Write("\nIngrese el título del libro: ");
            string titulo = Console.ReadLine();
            Console.Write("Ingrese el autor: ");
            string autor = Console.ReadLine();
            Console.Write("Ingrese el año de publicación: ");
            int año = int.Parse(Console.ReadLine());

            biblioteca.Add(new Libro(titulo, autor, año));
            Console.WriteLine("✅ Libro agregado correctamente.");
        }

        // Función para mostrar todos los libros
        static void MostrarLibros()
        {
            Console.WriteLine("\n=== LISTA DE LIBROS ===");
            if (biblioteca.Count == 0)
                Console.WriteLine("No hay libros registrados.");
            else
                foreach (Libro libro in biblioteca)
                    libro.MostrarInfo();
        }

        // Función para buscar libros por autor
        static void BuscarPorAutor()
        {
            Console.Write("\nIngrese el nombre del autor: ");
            string autorBuscado = Console.ReadLine();
            bool encontrado = false;

            foreach (Libro libro in biblioteca)
            {
                if (libro.Autor.ToLower() == autorBuscado.ToLower())
                {
                    libro.MostrarInfo();
                    encontrado = true;
                }
            }

            if (!encontrado)
                Console.WriteLine("No se encontraron libros de ese autor.");
        }
    }
}