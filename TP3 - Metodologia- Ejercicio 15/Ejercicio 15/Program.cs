using System;
using System.Collections;

namespace Metodologia
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Crear profesor y alumno favorito
            Console.WriteLine("Creando el profesor...");
            Profesor profesor = new Profesor("Roberto", 12345678, 10);
            
            Console.WriteLine("Creando el alumno favorito...");
            AlumnoFavorito alumnoFavorito = (AlumnoFavorito)FabricaDeComparables.crearAleatorio(4);
            
            // 2. CORRECCIÓN: Asignar la referencia del profesor al alumno favorito
            alumnoFavorito.setProfesor(profesor);

            // 3. Hacer que el profesor sea observador del alumno favorito
            profesor.agregarObservador(alumnoFavorito);

            // 4. Crear 20 alumnos "normales"
            Console.WriteLine("Creando 20 alumnos...");
            Pila pilaAlumnos = new Pila(new EstrategiaPorPromedio());
            for (int i = 0; i < 20; i++)
            {
                IComparable alumno = FabricaDeComparables.crearAleatorio(1);
                pilaAlumnos.agregar(alumno);
            }

            // 5. Configurar la cadena de observación
            Iterador iteradorAlumnos = pilaAlumnos.crearIterador();
            while (iteradorAlumnos.tieneSiguiente())
            {
                IComparable comparable = (IComparable)iteradorAlumnos.siguiente();
                // Todos los alumnos (normales y favoritos) observan al profesor
                profesor.agregarObservador((IObservador)comparable);
            }

            // 6. Simular una clase
            Console.WriteLine("\n--- Simulación de la clase ---");
            profesor.hablarAClase();
            profesor.escribirEnElPizarron();
            
            // Simular que un alumno normal se distrae lanzando un avion de papel
            Console.WriteLine("\nUn alumno normal lanza un avion de papel...");
            // Como el alumno favorito "detecta" esta distracción, lo notificas directamente al alumno favorito
            alumnoFavorito.actualizar("tira_avion_de_papel");

            Console.WriteLine("\nFin del programa. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        // Se mantienen los demás métodos, aunque no se usen en este Main
        static void llenar(Coleccionable col, int opcion)
        {
            Console.WriteLine("Llenando la colección con 20 " + (opcion == 1 ? "alumnos" : opcion == 2 ? "numeros" : opcion == 3 ? "profesores" : "alumnos favoritos") + "...");
            for (int i = 0; i < 20; i++)
            {
                IComparable comparable = FabricaDeComparables.crearAleatorio(opcion);
                col.agregar(comparable);
            }
        }
        
        static void informar(Coleccionable col, int opcion)
        {
            Console.WriteLine();
            Console.WriteLine("--- Información de la colección ---");
            Console.WriteLine("Cantidad de elementos: " + col.cuantos());
            IComparable min = col.minimo();
            IComparable max = col.maximo();

            if (min != null) Console.WriteLine("Elemento mínimo: " + min);
            if (max != null) Console.WriteLine("Elemento máximo: " + max);

            Console.WriteLine();
            Console.WriteLine("--- Verificando existencia de un elemento ---");
            IComparable comparablePorTeclado = FabricaDeComparables.crearPorTeclado(opcion);

            if (col.contiene(comparablePorTeclado))
            {
                Console.WriteLine("El elemento leído está en la colección.");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección.");
            }
        }
        
        static void dictadoDeClases(Profesor profesor)
        {
            Console.WriteLine();
            Console.WriteLine("El profesor " + profesor.getNombre() + " va a empezar a dictar clases.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("--- Turno " + (i + 1) + " ---");
                profesor.hablarAClase();
                profesor.escribirEnElPizarron();
                Console.WriteLine();
            }
        }
    }
}