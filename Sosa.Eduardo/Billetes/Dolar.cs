using System;

namespace Billetes
{
    public class Dolar
    {
        double cantidad;
        static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
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
        public static explicit operator Euro(Dolar d)
        {
            return new Euro((d.GetCantida() / Euro.GetCotizacion()));
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso((d.GetCantida() * Peso.GetCotizacion()));
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        //!=
        public static bool operator !=(Dolar d, Euro e)
        {
            bool isEqual = false;
            if ((Euro)d != e)
            {
                isEqual = true;
            }
            return isEqual;
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            bool isEqual = false;
            if ((Peso)d != p)
            {
                isEqual = true;
            }
            return isEqual;
        }

        public static bool operator !=(Dolar d, Dolar d1)
        {
            bool isEqual = false;
            if (d.GetCantida() != d1.GetCantida())
            {
                isEqual = true;
            }
            return isEqual;
        }

        //==
        public static bool operator ==(Dolar d, Euro e)
        {
            bool isEqual = false;
            if ((Euro)d == e)
            {
                isEqual = true;
            }
            return isEqual;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            bool isEqual = false;
            if ((Peso)d == p)
            {
                isEqual = true;
            }
            return isEqual;
        }
      
        public static bool operator ==(Dolar d, Dolar d1)
        {
            bool isEqual = false;
            if (d.GetCantida() == d1.GetCantida())
            {
                isEqual = true;
            }
            return isEqual;
        }

        //-

        public static Dolar operator -(Dolar d, Euro e)
        {
            return d - (Dolar)e;
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return d - (Dolar)p;
        }

        public static Dolar operator -(Dolar d, Dolar d1)
        {
            return new Dolar(d.GetCantida() - d1.GetCantida());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return d + (Dolar)e;
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return d + (Dolar)p;
        }

        public static Dolar operator +(Dolar d, Dolar d1)
        {
            return new Dolar(d.GetCantida() + d1.GetCantida());
        }

    }
}
