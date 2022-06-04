using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTempera
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private Int32 cantidad;

       

        public Tempera(ConsoleColor color)
        {
            this.color = color;
        }

        public Tempera(ConsoleColor color, string marca) : this(color)
        {
            this.marca = marca;
        }

        public Tempera(ConsoleColor color, string marca, Int32 cantidad):this(color,marca)
        {
            this.cantidad = cantidad;            
        }

        public Int32 Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        private string Mostrar()
        {            
            return (new StringBuilder($"Boligrafo {this.marca} {this.color} con {this.cantidad} de tinta ").ToString());
        }

        public string Mostrar(Tempera temperaImpresion)
        {
            return temperaImpresion.Mostrar();
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool isSame = false;
            if (t1.marca == t2.marca && t1.color == t2.color)
            {
                isSame = true;
            }
            return isSame;
        }
        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static implicit operator int(Tempera tempera)
        {
            return tempera.cantidad;
        }

        public static Tempera operator  +(Tempera t1, Tempera t2)
        {
            Tempera resultado = t1;
            if (t1 is Tempera && t2 is Tempera)
            {
                if (t1 == t2)
                {
                    resultado = new Tempera(t1.color, t1.marca, t1.cantidad + t2.cantidad);                   
                }
            }
            return resultado;         
        }

        public static Tempera operator +(Tempera t1, int cantidad)
        {
            Tempera resultado = t1;
            if (t1 is Tempera && cantidad>0)
            {                
                    resultado = new Tempera(t1.color, t1.marca, t1.cantidad + cantidad);                
            }
            return resultado;
        }
    }
}
