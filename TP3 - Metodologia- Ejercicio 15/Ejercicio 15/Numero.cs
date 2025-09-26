using System;

namespace Metodologia
{
    public class Numero : IComparable
    {
        private int valor;

        public Numero(int v)
        {
            valor = v;
        }

        public int getValor()
        {
            return valor;
        }

        public bool SosIgual(IComparable c)
        {
            Numero otro = (Numero)c;
            return valor == otro.getValor();
        }

        public bool SosMenor(IComparable c)
        {
            Numero otro = (Numero)c;
            return valor < otro.getValor();
        }

        public bool SosMayor(IComparable c)
        {
            Numero otro = (Numero)c;
            return valor > otro.getValor();
        }

        public override string ToString()
        {
            return valor.ToString();
        }
    }
}
