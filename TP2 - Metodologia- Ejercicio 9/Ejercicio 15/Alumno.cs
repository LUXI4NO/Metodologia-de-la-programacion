using System;

namespace Metodologia
{
    public class Alumno : Persona
    {
        int legajo;       
        double promedio; 
        IEstrategiaDeComparacion est;

        public Alumno(string nombre, int dni, int leg, double prm, IEstrategiaDeComparacion est) : base(nombre, dni)
        {
            this.legajo = leg;
            this.promedio = prm;
            this.est = est;
        }

        public int obtenerLegajo()
        {
            return legajo;
        }

        public double obtenerPromedio()
        {
            return promedio;
        }

        public void setEstrategia(IEstrategiaDeComparacion e)
        {
            this.est = e;
        }

        public override bool SosIgual(IComparable otro)
        {
            Alumno a = otro as Alumno;
            if (a == null) return false;
            return est.SonIguales(this, a);
        }

        public override bool SosMenor(IComparable otro)
        {
            Alumno a = otro as Alumno;
            if (a == null) return false;
            return est.EsMenor(this, a);
        }

        public override bool SosMayor(IComparable otro)
        {
            Alumno a = otro as Alumno;
            if (a == null) return false;
            return est.EsMayor(this, a);
        }

        public override string ToString()
        {
            return base.ToString() + " | leg " + legajo + " | prom " + promedio;
        }
    }
}
