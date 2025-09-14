using System;

namespace Metodologia
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            IEstrategiaDeComparacion estNom = new EstrategiaPorNombre();
            IEstrategiaDeComparacion estLeg = new EstrategiaPorLegajo();
            IEstrategiaDeComparacion estProm = new EstrategiaPorPromedio();
            IEstrategiaDeComparacion estDni = new EstrategiaPorDNI();

            Pila pila = new Pila(estNom);
            cargarAlumnos(pila);

            Console.WriteLine("Pila ejercicio 9");
            Console.WriteLine();

            Console.WriteLine("Estrategia por nombre");
            cambiarEstrategia(pila, estNom);
            mostrarInfo(pila);
            Console.WriteLine();

            Console.WriteLine("Estrategia por legajo");
            cambiarEstrategia(pila, estLeg);
            mostrarInfo(pila);
            Console.WriteLine();

            Console.WriteLine("Estrategia por promedio");
            cambiarEstrategia(pila, estProm);
            mostrarInfo(pila);
            Console.WriteLine();

            Console.WriteLine("Estrategia por dni");
            cambiarEstrategia(pila, estDni);
            mostrarInfo(pila);
            Console.WriteLine();

            Console.WriteLine("Fin, tecla para salir");
            Console.ReadKey();
        }

        static void cargarAlumnos(Coleccionable col)
        {
            string[] nombres = { "Luciano", "Eliana", "Mateo", "Sebastian", "Carmen", "Ana", "Pedro", "Sofia", "Jorge", "Maria" };
            for (int i = 0; i < 20; i++)
            {
                string nom = nombres[rnd.Next(nombres.Length)];
                int dni = rnd.Next(20000000, 45000000);
                int leg = rnd.Next(1000, 5000);
                double prom = Math.Round(rnd.NextDouble() * 10, 2);

                Alumno alu = new Alumno(nom, dni, leg, prom, col.EstrategiaDeComparacion);
                col.agregar(alu);
            }
        }

        static void mostrarInfo(Coleccionable col)
        {
            Console.WriteLine("Cantidad: " + col.cuantos());
            IComparable min = col.minimo();
            IComparable max = col.maximo();

            if (min != null) Console.WriteLine("Min: " + min);
            if (max != null) Console.WriteLine("Max: " + max);
        }

        static void cambiarEstrategia(Iterable col, IEstrategiaDeComparacion est)
        {
            Iterador it = col.crearIterador();
            while (it.tieneSiguiente())
            {
                Alumno a = (Alumno)it.siguiente();
                a.setEstrategia(est);
            }
        }
    }
}
