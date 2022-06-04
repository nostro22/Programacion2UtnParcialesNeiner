using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        double cantidad;
        static double cotzRespectoDolar;

        static Peso() 
        {
            cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;            
        }

        public double GetCantida()
        {
            return this.cantidad;
        }
  


        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }


        public static explicit operator Dolar(Peso p)
        {
            return new Dolar((p.GetCantida() / Peso.GetCotizacion()));
        }
        public static explicit operator Euro(Peso p)
        {
            Dolar transitorio = (Dolar)p;

            return new Euro(transitorio.GetCantida() / Euro.GetCotizacion());
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        //!=
        public static bool operator !=(Peso p, Dolar d)
        {
            bool isEqual = false;
            if ((Peso)d != p)
            {
                isEqual = true;
            }
            return isEqual;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            bool isEqual = false;
            if ((Peso)e != p)
            {
                isEqual = true;
            }
            return isEqual;
        }

        public static bool operator !=(Peso p, Peso p1)
        {
            bool isEqual = false;
            if (p.GetCantida() != p1.GetCantida())
            {
                isEqual = true;
            }
            return isEqual;
        }

        //==
        public static bool operator ==(Peso p, Dolar d)
        {
           
            return !(p!=d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
          
            return !(p!=e);
        }

        public static bool operator ==(Peso p, Peso p1)
        {
            
            return !(p!=p1);
        }

        //-

        public static Peso operator -(Peso p, Dolar d)
        {
            return p - (Peso)d;
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return p - (Peso)e;
        }

        public static Peso operator -(Peso p, Peso p1)
        {
            return new Peso(p.GetCantida() - p1.GetCantida());
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return p + (Peso)d;
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return p + (Peso)e;
        }

        public static Peso operator +(Peso p, Peso p1)
        {
            return new Peso(p.GetCantida() + p1.GetCantida());
        }
    }
}
