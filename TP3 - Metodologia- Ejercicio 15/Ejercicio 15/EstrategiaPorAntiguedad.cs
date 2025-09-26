using System;

namespace Metodologia
{
    public class EstrategiaPorAntiguedad : IEstrategiaDeComparacion
    {
        public bool SonIguales(Alumno a1, Alumno a2)
        {
            // Esta estrategia no se usa para comparar alumnos,
            // pero la interfaz exige la implementación.
            // Retornamos false o lanzamos una excepción si es necesario.
            return false;
        }

        public bool EsMenor(Alumno a1, Alumno a2)
        {
            // Similar al caso anterior, esta estrategia no compara alumnos.
            return false;
        }

        public bool EsMayor(Alumno a1, Alumno a2)
        {
            // Similar al caso anterior, esta estrategia no compara alumnos.
            return false;
        }
        
        // Se sobrecargan los métodos para que acepten Profesores
        public bool SonIguales(Profesor p1, Profesor p2)
        {
            return p1.getAntiguedad() == p2.getAntiguedad();
        }
        
        public bool EsMenor(Profesor p1, Profesor p2)
        {
            return p1.getAntiguedad() < p2.getAntiguedad();
        }
        
        public bool EsMayor(Profesor p1, Profesor p2)
        {
            return p1.getAntiguedad() > p2.getAntiguedad();
        }
    }
}