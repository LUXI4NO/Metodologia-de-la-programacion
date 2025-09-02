namespace Metodologia
{
    public class Alumno : Persona
    {
        private int legajo;       
        private double promedio; 

        public Alumno(string nombre, int dni, int legajoAlumno, double prom) : base(nombre, dni)
        {
            legajo = legajoAlumno;
            promedio = prom;
        }

        public int obtenerLegajo()
        {
            return legajo;
        }

        public double obtenerPromedio()
        {
            return promedio;
        }

        public override bool SosIgual(IComparable otro)
        {
            Alumno a = otro as Alumno;
            if (a != null)
            {
                return this.legajo == a.legajo;
            }
            return false;
        }

        public override bool SosMenor(IComparable otro)
        {
            Alumno a = otro as Alumno;
            if (a != null)
            {
                return this.legajo < a.legajo;
            }
            return false;
        }

        public override bool SosMayor(IComparable otro)
        {
            Alumno a = otro as Alumno;
            if (a != null)
            {
                return this.legajo > a.legajo;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + " | Legajo: " + legajo + " | Promedio: " + promedio;
        }
    }
}

