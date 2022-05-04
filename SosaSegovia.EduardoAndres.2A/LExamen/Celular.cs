using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public class Celular:Producto
    {
        //campos

        public EGama gama;

        //Metyhods

        public Celular(string modelo, Fabricante fabricante, EGama gama):base(modelo,fabricante)
        {
            this.gama = gama;
        }

        public override bool Equals(object obj)
        {
            return (obj is Celular celular && this is not null && this == (Celular)obj);
        }

        public static implicit operator Double(Celular celu)
        {
            return celu.precio;
        }

        public static bool operator ==(Celular a, Celular b)
        {
            return (a is Celular && b is Celular && a == (Producto)b && a.gama == b.gama);
        }



        public static bool operator !=(Celular a, Celular b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)((Producto)(this)));
            sb.Append("Gama: " + this.gama);
            sb.AppendLine("");


            return sb.ToString();
        }
    }
}
