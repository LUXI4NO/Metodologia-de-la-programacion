using System;

namespace Metodologia
{
    public class Alumno : Persona, IObservador
    {
        int legajo;
        double promedio;
        IEstrategiaDeComparacion est;
        private static Random rnd = new Random();
        private string[] frasesDistraccion = { "Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel" };

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
        
        public void actualizar(string accion)
        {
            if (accion == "hablar")
            {
                prestarAtencion();
            }
            else if (accion == "escribir")
            {
                distraerse();
            }
        }
        
        public void prestarAtencion()
        {
            Console.WriteLine("Prestando atención.");
        }

        public virtual void distraerse() // Se ha añadido 'virtual' aquí
        {
            string frase = frasesDistraccion[rnd.Next(frasesDistraccion.Length)];
            Console.WriteLine(frase);
        }
    }
}