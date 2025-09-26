using System;

namespace Metodologia
{
    public class EstrategiaPorDNI : IEstrategiaDeComparacion
    {
        public bool SonIguales(Alumno a1, Alumno a2)
        {
            return a1.getDNI() == a2.getDNI();
        }

        public bool EsMenor(Alumno a1, Alumno a2)
        {
            return a1.getDNI() < a2.getDNI();
        }

        public bool EsMayor(Alumno a1, Alumno a2)
        {
            return a1.getDNI() > a2.getDNI();
        }
    }
}