using System.Collections;

namespace Metodologia
{
    public class Pila : Coleccionable
    {
        ArrayList elementos;

        public Pila()
        {
            elementos = new ArrayList();
        }

        public ArrayList getElementos()
        {
            return elementos;
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public IComparable minimo()
        {
            if(elementos.Count == 0) return null;

            IComparable min = (IComparable)elementos[0];
            for(int i = 1; i < elementos.Count; i++)
                if(((IComparable)elementos[i]).SosMenor(min)) min = (IComparable)elementos[i];

            return min;
        }

        public IComparable maximo()
        {
            if(elementos.Count == 0) return null;

            IComparable max = (IComparable)elementos[0];
            for(int i = 1; i < elementos.Count; i++)
                if(((IComparable)elementos[i]).SosMayor(max)) max = (IComparable)elementos[i];

            return max;
        }

        public void agregar(IComparable c)
        {
            elementos.Add(c);
        }

        public bool contiene(IComparable c)
        {
            foreach(IComparable item in elementos)
                if(item.SosIgual(c)) return true;

            return false;
        }

        public void apilar(IComparable c)
        {
            elementos.Add(c);
        }

        public IComparable desapilar()
        {
            if(elementos.Count == 0) return null;

            IComparable top = (IComparable)elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);
            return top;
        }
    }
}
