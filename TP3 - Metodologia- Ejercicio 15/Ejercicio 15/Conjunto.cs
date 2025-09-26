using System.Collections;

namespace Metodologia
{
    public class Conjunto : Coleccionable, Iterable
    {
        private ArrayList elementos;
        public IEstrategiaDeComparacion EstrategiaDeComparacion { get; set; }

        public Conjunto(IEstrategiaDeComparacion estrategia)
        {
            this.elementos = new ArrayList();
            this.EstrategiaDeComparacion = estrategia;
        }

        public int cuantos()
        {
            return this.elementos.Count;
        }

        public IComparable minimo()
        {
            if (this.elementos.Count == 0)
            {
                return null;
            }

            IComparable minimo = (IComparable)this.elementos[0];
            foreach (IComparable c in this.elementos)
            {
                if (c.SosMenor(minimo))
                {
                    minimo = c;
                }
            }
            return minimo;
        }

        public IComparable maximo()
        {
            if (this.elementos.Count == 0)
            {
                return null;
            }

            IComparable maximo = (IComparable)this.elementos[0];
            foreach (IComparable c in this.elementos)
            {
                if (c.SosMayor(maximo))
                {
                    maximo = c;
                }
            }
            return maximo;
        }

        public void agregar(IComparable c)
        {
            if (!this.contiene(c))
            {
                this.elementos.Add(c);
            }
        }

        public bool contiene(IComparable c)
        {
            foreach (IComparable elementoExistente in this.elementos)
            {
                if (elementoExistente.SosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
        
        public Iterador crearIterador()
        {
            return new IteradorConjunto(this.elementos);
        }
    }
}