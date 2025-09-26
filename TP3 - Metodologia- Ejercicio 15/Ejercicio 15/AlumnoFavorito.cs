using System;
using System.Collections;

namespace Metodologia
{
    public class AlumnoFavorito : Alumno, IObservador
    {
        private IObservable profesorObservable;
        private ArrayList observadoresDistraidos; // Alumnos que se distraen

        public AlumnoFavorito(string nombre, int dni, int leg, double prm, IEstrategiaDeComparacion est)
            : base(nombre, dni, leg, prm, est)
        {
            this.observadoresDistraidos = new ArrayList();
        }

        public override void distraerse() 
        {
            Console.WriteLine("Yo nunca me distraigo, siempre presto atencion.");
        }
        
        public void setProfesor(IObservable profesor)
        {
            this.profesorObservable = profesor;
        }

        public void agregarObservador(IObservador o)
        {
            this.observadoresDistraidos.Add(o);
        }
        
        public new void actualizar(string accion)
        {
            if (accion == "tira_avion_de_papel")
            {
                // Solo un ejemplo para notificar
                Console.WriteLine("Alumno favorito notando que un compañero se distrae...");
                profesorObservable.notificarObservadores("silencio");
            }
        }
    }
}