using System;

namespace Metodologia
{
    public class FabricaDeAlumnos : IFabricaDeComparables
    {
        private static Random rnd = new Random();
        private IEstrategiaDeComparacion estrategia;

        public FabricaDeAlumnos(IEstrategiaDeComparacion est)
        {
            this.estrategia = est;
        }

        public IComparable crearComparable()
        {
            string[] nombres = { "Luciano", "Eliana", "Mateo", "Sebastian", "Carmen", "Ana", "Pedro", "Sofia", "Jorge", "Maria" };
            string nom = nombres[rnd.Next(nombres.Length)];
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(25000000) + 20000000;
            int leg = GeneradorDeDatosAleatorios.numeroAleatorio(4000) + 1000;
            double prom = GeneradorDeDatosAleatorios.numeroAleatorio(100) / 10.0;
            
            return new Alumno(nom, dni, leg, prom, this.estrategia);
        }
    }
}