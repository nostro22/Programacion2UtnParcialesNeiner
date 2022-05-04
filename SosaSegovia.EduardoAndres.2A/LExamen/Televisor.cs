using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public class Televisor:Producto
    {
        //campos

        public ETipo tipo;

        //Methods

        public override bool Equals(object obj)
        {
            return (obj is Televisor televisor && this is not null && this == (Televisor)obj);
        }

        public static explicit operator Double(Televisor tv)
        {
            return tv.precio;
        }

        public static bool operator ==(Televisor a, Televisor b)
        {
            return (a is not null && b is not null && a == (Producto)b && a.tipo == b.tipo);
        }



        public static bool operator !=(Televisor a, Televisor b)
        {
            return !(a == b);
        }

        public Televisor(string modelo, string marca, EPais pais, ETipo tipo):base(modelo,(new Fabricante(marca,pais)))
        {
            this.tipo = tipo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)((Producto)(this)));
            sb.Append("Tipo: " + this.tipo);
            sb.AppendLine("");
            return sb.ToString();
        }
    }
}
