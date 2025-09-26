using System;

namespace Metodologia
{
    public static class LectorDeDatos
    {
        public static int numeroPorTeclado()
        {
            Console.WriteLine("Por favor, ingrese un número:");
            string input = Console.ReadLine();
            return int.Parse(input);
        }

        public static string stringPorTeclado()
        {
            Console.WriteLine("Por favor, ingrese una cadena de texto:");
            return Console.ReadLine();
        }
    }
}