using System.Collections;

namespace Metodologia
{
    public class IteradorCola : Iterador
    {
        private ArrayList elementos;
        private int posicionActual;

        public IteradorCola(ArrayList elementos)
        {
            this.elementos = elementos;
            this.posicionActual = 0;
        }

        public bool tieneSiguiente()
        {
            return this.posicionActual < this.elementos.Count;
        }

        public object siguiente()
        {
            object elemento = this.elementos[this.posicionActual];
            this.posicionActual++;
            return elemento;
        }
    }
}