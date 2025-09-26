using System;

namespace Metodologia
{
    public interface Coleccionable
    {
        IEstrategiaDeComparacion EstrategiaDeComparacion { get; set; }
        int cuantos();
        IComparable minimo();
        IComparable maximo();
        void agregar(IComparable c);
        bool contiene(IComparable c);
    }
}