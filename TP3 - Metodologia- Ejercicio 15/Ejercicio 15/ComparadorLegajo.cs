using System;

namespace Metodologia
{
    public class EstrategiaPorLegajo : IEstrategiaDeComparacion
    {
        public bool SonIguales(Alumno a1, Alumno a2)
        {
            return a1.obtenerLegajo() == a2.obtenerLegajo();
        }

        public bool EsMenor(Alumno a1, Alumno a2)
        {
            return a1.obtenerLegajo() < a2.obtenerLegajo();
        }

        public bool EsMayor(Alumno a1, Alumno a2)
        {
            return a1.obtenerLegajo() > a2.obtenerLegajo();
        }
    }
}