using System;

namespace Metodologia
{
    public class FabricaDeNumeros : IFabricaDeComparables
    {
        public IComparable crearComparable()
        {
            return new Numero(GeneradorDeDatosAleatorios.numeroAleatorio(100));
        }
    }
}