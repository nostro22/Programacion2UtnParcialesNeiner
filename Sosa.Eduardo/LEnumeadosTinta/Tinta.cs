using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LEnumeadosTinta
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color)
        {
            this.color = color;
            this.tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo)
        {
            this.color = color;
            this.tipo = tipo;
        }

        private string Mostrar()
        {
            string tintaString = this.color.ToString();
            string tipo = this.tipo.ToString();
            return ("tinta de color " + tintaString + " con tipo de tinta " + tipo);
        }
        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }


        public static bool  operator ==(Tinta t1, Tinta t2)
        {

        return (t1.tipo==t2.tipo && t1.color == t2.color);
        }

        public static bool  operator !=(Tinta t1, Tinta t2)
        {

        return !(t1==t2);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Tinta)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return GetHashCode();
            }
        }

        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }

    }
 
}

