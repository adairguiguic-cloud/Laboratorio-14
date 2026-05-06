using System;
namespace Lab14AG_1363526
{
    class Libro
    {
        string titulo;
        string autor;
        int anio;
        bool disponible;

        public Libro(string t, string a, int an, bool disp)
        {
            titulo = t;
            autor = a;
            anio = an;
            disponible = disp;
        }

        public void Mostrar()
        {
            Console.WriteLine("Titulo: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Año: " + anio);
            Console.WriteLine("Disponible: " + (disponible ? "Si" : "No"));
            Console.WriteLine("----------------------");
        }

        public void Prestar()
        {
            if (disponible)
            {
                disponible = false;
                Console.WriteLine("Libro prestado");
            }
            else
            {
                Console.WriteLine("Ya estaba prestado");
            }
        }

        public void Devolver()
        {
            disponible = true;
            Console.WriteLine("Libro devuelto");
        }
    }

    class Mascota
    {
        string nombre;
        string especie;
        int edad;
        bool vacunado;

        public Mascota(string n, string e, int ed, bool v)
        {
            nombre = n;
            especie = e;
            edad = ed;
            vacunado = v;
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Especie: " + especie);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Vacunado: " + (vacunado ? "Si" : "No"));
            Console.WriteLine("----------------------");
        }

        public void Vacunar()
        {
            vacunado = true;
            Console.WriteLine(nombre + " vacunado");
        }

        public void Cumplir()
        {
            edad++;
            Console.WriteLine(nombre + " ahora tiene " + edad);
        }
    }

    class Estudiante
    {
        string nombre;
        int edad;
        string grado;
        decimal[] notas;

        public Estudiante(string n, int e, string g, decimal[] nt)
        {
            nombre = n;
            edad = e;
            grado = g;
            notas = nt;
        }

        public decimal Promedio()
        {
            decimal suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }
            return suma / notas.Length;
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Grado: " + grado);
            Console.WriteLine("Promedio: " + Promedio());
            Console.WriteLine("----------------------");
        }

        public void Aprobar()
        {
            if (Promedio() >= 61)
                Console.WriteLine(nombre + " aprobo");
            else
                Console.WriteLine(nombre + " reprobo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab14 AG - 1363526\n");

            // Libros
            Libro l1 = new Libro("Cien años de soledad", "Gabo", 1967, true);
            l1.Mostrar();
            l1.Prestar();
            l1.Mostrar();

            // Mascotas
            Mascota m1 = new Mascota("Firulais", "Perro", 3, false);
            m1.Mostrar();
            m1.Vacunar();
            m1.Cumplir();
            m1.Mostrar();

            // Estudiante
            decimal[] notas = { 70, 80, 60, 90 };
            Estudiante e1 = new Estudiante("Ana", 16, "10mo", notas);
            e1.Mostrar();
            e1.Aprobar();

            Console.ReadKey();
        }
    }
}