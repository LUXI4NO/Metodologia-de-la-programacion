using System.Collections;

namespace Metodologia
{
    public class IteradorPila : Iterador
    {
        private ArrayList elementos;
        private int posicionActual;

        public IteradorPila(ArrayList elementos)
        {
            this.elementos = elementos;
            this.posicionActual = elementos.Count - 1;
        }

        public bool tieneSiguiente()
        {
            return this.posicionActual >= 0;
        }

        public object siguiente()
        {
            object elemento = this.elementos[this.posicionActual];
            this.posicionActual--;
            return elemento;
        }
    }
}