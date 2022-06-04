using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        double cantidad;
        static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad)
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


        public static explicit operator Dolar( Euro e)
        {
            return new Dolar((e.GetCantida() * Euro.GetCotizacion()));
        }
        public static explicit operator Peso(Euro e)
        {
            Dolar transitorio = (Dolar)e;

            return new Peso(transitorio.GetCantida() * Peso.GetCotizacion());
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        //!=
        public static bool operator !=(Euro e, Dolar d)
        {
            bool isEqual = false;
            if ((Euro)d != e)
            {
                isEqual = true;
            }
            return isEqual;
        }

        public static bool operator !=(Euro e, Peso p)
        {
            bool isEqual = false;
            if ((Peso)e != p)
            {
                isEqual = true;
            }
            return isEqual;
        }

        public static bool operator !=(Euro e, Euro e1)
        {
            bool isEqual = false;
            if (e.GetCantida() != e1.GetCantida())
            {
                isEqual = true;
            }
            return isEqual;
        }

        //==
        public static bool operator ==(Euro e, Dolar d)
        {
            
            return !(e!=d);
        }

        public static bool operator ==(Euro e, Peso p)
        {

            return !(e != p);
        }

        public static bool operator ==(Euro e, Euro e1)
        {
            return !(e != e1);
        }

        //-

        public static Euro operator -( Euro e,Dolar d)
        {
            return e - (Euro)d;
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return e - (Euro)p;
        }

        public static Euro operator -(Euro e, Euro e1)
        {
            return new Euro(e.GetCantida() - e1.GetCantida());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e + (Euro)d;
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return e + (Euro)p;
        }

        public static Euro operator +(Euro e, Euro e1)
        {
            return new Euro(e.GetCantida() + e1.GetCantida());
        }
    }
}
