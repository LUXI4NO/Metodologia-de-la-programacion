using System;

namespace Metodologia
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

            llenarAlumnos(pila);
            llenarAlumnos(cola);

            Console.WriteLine("=== Pila ===");
            informar(pila);

            Console.WriteLine("\n=== Cola ===");
            informar(cola);

            Console.WriteLine("\n=== ColeccionMultiple ===");
            informar(multiple);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void llenarAlumnos(Coleccionable coleccionable)
        {
            string[] nombres = { "Luciano", "Eliana", "Mateo", "Sebastian", "Carmen" };

            for(int i = 0; i < 10; i++)
            {
                string nombre = nombres[random.Next(nombres.Length)];
                int dni = random.Next(20000000, 45000000);
                int legajo = random.Next(1000, 5000);
                double promedio = Math.Round(random.NextDouble() * 10, 2);

                IComparable alumno = new Alumno(nombre, dni, legajo, promedio);
                coleccionable.agregar(alumno);
            }
        }

        static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine("Cantidad de elementos: " + coleccionable.cuantos());

            IComparable minimo = coleccionable.minimo();
            IComparable maximo = coleccionable.maximo();

            if(minimo != null && maximo != null)
            {
                Console.WriteLine("Elemento mínimo: " + minimo);
                Console.WriteLine("Elemento máximo: " + maximo);
            }

            Console.Write("Ingrese un DNI a buscar: ");
            string input = Console.ReadLine();
            int dni;
            if(int.TryParse(input, out dni))
            {
                bool encontrado = coleccionable.contiene(new Alumno("", dni, 0, 0));
                if(encontrado) Console.WriteLine("El alumno con DNI " + dni + " está en la colección.");
                else Console.WriteLine("No se encontró el alumno con DNI " + dni + ".");
            }
            else Console.WriteLine("Entrada inválida.");
        }
    }
}
