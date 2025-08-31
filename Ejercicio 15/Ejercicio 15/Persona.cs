namespace Metodologia
{
    public abstract class Persona : IComparable
    {
        string nombre;
        int dni;

        public Persona(string n, int d)
        {
            nombre = n;
            dni = d;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getDNI()
        {
            return dni;
        }

        public virtual bool SosIgual(IComparable comparable)
        {
            Persona p = (Persona)comparable;
            return dni == p.getDNI();
        }

        public virtual bool SosMenor(IComparable comparable)
        {
            Persona p = (Persona)comparable;
            return dni < p.getDNI();
        }

        public virtual bool SosMayor(IComparable comparable)
        {
            Persona p = (Persona)comparable;
            return dni > p.getDNI();
        }

        public override string ToString()
        {
            return nombre + " (DNI: " + dni + ")";
        }
    }
}
