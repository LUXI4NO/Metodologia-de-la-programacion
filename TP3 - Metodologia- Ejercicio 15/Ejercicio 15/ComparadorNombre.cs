using System;

namespace Metodologia
{
    public class EstrategiaPorNombre : IEstrategiaDeComparacion
    {
        public bool SonIguales(Alumno a1, Alumno a2)
        {
            return a1.getNombre() == a2.getNombre();
        }

        public bool EsMenor(Alumno a1, Alumno a2)
        {
            return string.Compare(a1.getNombre(), a2.getNombre()) < 0;
        }

        public bool EsMayor(Alumno a1, Alumno a2)
        {
            return string.Compare(a1.getNombre(), a2.getNombre()) > 0;
        }
    }
}