using System;

namespace Metodologia
{
    public class FabricaDeProfesores : IFabricaDeComparables
    {
        public IComparable crearComparable()
        {
            string[] nombres = { "Juan", "Maria", "Carlos", "Luisa", "Diego", "Ana", "Pablo", "Sofia", "Jorge", "Laura" };
            string nom = nombres[GeneradorDeDatosAleatorios.numeroAleatorio(nombres.Length - 1)];
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(25000000) + 20000000;
            int antiguedad = GeneradorDeDatosAleatorios.numeroAleatorio(30) + 1;

            return new Profesor(nom, dni, antiguedad);
        }
    }
}