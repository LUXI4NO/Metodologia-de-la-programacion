using System;
using System.Collections;
using System.Collections.Generic;

namespace Metodologia
{
    public class Profesor : Persona, IObservable, IObservador
    {
        private int antiguedad;
        private ArrayList observadores;

        public Profesor(string n, int d, int a) : base(n, d)
        {
            this.antiguedad = a;
            this.observadores = new ArrayList();
        }

        public int getAntiguedad()
        {
            return this.antiguedad;
        }

        public void hablarAClase()
        {
            Console.WriteLine("Hablando de algún tema.");
            notificarObservadores("hablar");
        }

        public void escribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarrón.");
            notificarObservadores("escribir");
        }

        public void hacerSilencio()
        {
            Console.WriteLine("¡Silencio, no se distraigan!");
        }

        // Métodos de la interfaz IObservable
        public void agregarObservador(IObservador o)
        {
            observadores.Add(o);
        }

        public void quitarObservador(IObservador o)
        {
            observadores.Remove(o);
        }

        public void notificarObservadores(string accion)
        {
            foreach (IObservador obs in observadores)
            {
                obs.actualizar(accion);
            }
        }

        // Método de la interfaz IObservador para recibir notificaciones
        public void actualizar(string accion)
        {
            if (accion == "silencio")
            {
                this.hacerSilencio();
            }
        }
    }
}