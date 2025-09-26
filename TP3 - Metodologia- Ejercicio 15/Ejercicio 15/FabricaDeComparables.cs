using System;

namespace Metodologia
{
    public abstract class FabricaDeComparables
    {
        public static IComparable crearAleatorio(int opcion)
        {
            if (opcion == 1)
            {
                IEstrategiaDeComparacion estrategia = new EstrategiaPorDNI();
                IFabricaDeComparables fabrica = new FabricaDeAlumnos(estrategia);
                return fabrica.crearComparable();
            }
            else if (opcion == 2)
            {
                IFabricaDeComparables fabrica = new FabricaDeNumeros();
                return fabrica.crearComparable();
            }
            else if (opcion == 3)
            {
                IFabricaDeComparables fabrica = new FabricaDeProfesores();
                return fabrica.crearComparable();
            }
            else if (opcion == 4)
            {
                IEstrategiaDeComparacion estrategia = new EstrategiaPorDNI();
                return new AlumnoFavorito(
                    GeneradorDeDatosAleatorios.stringAleatorio(10),
                    GeneradorDeDatosAleatorios.numeroAleatorio(25000000) + 20000000,
                    GeneradorDeDatosAleatorios.numeroAleatorio(4000) + 1000,
                    GeneradorDeDatosAleatorios.numeroAleatorio(100) / 10.0,
                    estrategia);
            }
            return null;
        }

        public static IComparable crearPorTeclado(int opcion)
        {
            if (opcion == 1)
            {
                Console.WriteLine("Creando un Alumno...");
                Console.Write("Ingrese el nombre: ");
                string nombre = LectorDeDatos.stringPorTeclado();
                Console.Write("Ingrese el DNI: ");
                int dni = LectorDeDatos.numeroPorTeclado();
                Console.Write("Ingrese el legajo: ");
                int legajo = LectorDeDatos.numeroPorTeclado();
                Console.Write("Ingrese el promedio: ");
                int promedio = LectorDeDatos.numeroPorTeclado();

                IEstrategiaDeComparacion estrategia = new EstrategiaPorDNI();
                return new Alumno(nombre, dni, legajo, promedio, estrategia);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Creando un Numero...");
                Console.Write("Ingrese el valor del número: ");
                int valor = LectorDeDatos.numeroPorTeclado();
                return new Numero(valor);
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Creando un Profesor...");
                Console.Write("Ingrese el nombre: ");
                string nombre = LectorDeDatos.stringPorTeclado();
                Console.Write("Ingrese el DNI: ");
                int dni = LectorDeDatos.numeroPorTeclado();
                Console.Write("Ingrese la antigüedad (en años): ");
                int antiguedad = LectorDeDatos.numeroPorTeclado();

                return new Profesor(nombre, dni, antiguedad);
            }
            return null; // Opción 4 para AlumnoFavorito no tiene creación por teclado en este ejercicio
        }
    }
}