using System.Collections;

namespace Metodologia
{
    public class Cola : Coleccionable, Iterable
    {
        ArrayList elementos;
        public IEstrategiaDeComparacion EstrategiaDeComparacion { get; set; }

        public Cola(IEstrategiaDeComparacion estrategia)
        {
            elementos = new ArrayList();
            this.EstrategiaDeComparacion = estrategia;
        }

        public ArrayList GetElementos()
        {
            return elementos;
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public IComparable minimo()
        {
            if (elementos.Count == 0)
            {
                return null;
            }

            IComparable min = (IComparable)elementos[0];
            for (int i = 1; i < elementos.Count; i++)
            {
                if (((IComparable)elementos[i]).SosMenor(min))
                    min = (IComparable)elementos[i];
            }
            return min;
        }
        
        public IComparable maximo()
        {
            if (elementos.Count == 0)
            {
                return null;
            }

            IComparable max = (IComparable)elementos[0];
            for (int i = 1; i < elementos.Count; i++)
            {
                if (((IComparable)elementos[i]).SosMayor(max))
                    max = (IComparable)elementos[i];
            }
            return max;
        }

        public void agregar(IComparable c)
        {
            elementos.Add(c);
        }

        public bool contiene(IComparable c)
        {
            foreach (IComparable item in elementos)
            {
                if (item.SosIgual(c)) return true;
            }
            
            return false;
        }

        public void encolar(IComparable c)
        {
            elementos.Add(c);
        }

        public IComparable desencolar()
        {
            if (elementos.Count == 0)
            {
                return null;
            }
            IComparable primero = (IComparable)elementos[0];
            elementos.RemoveAt(0);
            return primero;
        }

        public Iterador crearIterador()
        {
            return new IteradorCola(this.elementos);
        }
    }
}