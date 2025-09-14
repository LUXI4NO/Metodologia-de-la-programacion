using System;

namespace Metodologia
{
    public interface IEstrategiaDeComparacion
    {
        bool SonIguales(Alumno a1, Alumno a2);
        bool EsMenor(Alumno a1, Alumno a2);
        bool EsMayor(Alumno a1, Alumno a2);
    }
}