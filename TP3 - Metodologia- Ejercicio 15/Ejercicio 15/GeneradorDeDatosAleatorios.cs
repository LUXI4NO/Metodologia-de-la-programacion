using System;
using System.Text;

namespace Metodologia
{
    public static class GeneradorDeDatosAleatorios
    {
        private static Random rnd = new Random();

        public static int numeroAleatorio(int max)
        {
            return rnd.Next(max + 1);
        }

        public static string stringAleatorio(int cant)
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < cant; i++)
            {
                sb.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return sb.ToString();
        }
    }
}