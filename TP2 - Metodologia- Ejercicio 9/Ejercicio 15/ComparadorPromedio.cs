using System;

namespace Metodologia
{
    public class EstrategiaPorPromedio : IEstrategiaDeComparacion
    {
        public bool SonIguales(Alumno a1, Alumno a2)
        {
            return a1.obtenerPromedio() == a2.obtenerPromedio();
        }

        public bool EsMenor(Alumno a1, Alumno a2)
        {
            return a1.obtenerPromedio() < a2.obtenerPromedio();
        }

        public bool EsMayor(Alumno a1, Alumno a2)
        {
            return a1.obtenerPromedio() > a2.obtenerPromedio();
        }
    }
}