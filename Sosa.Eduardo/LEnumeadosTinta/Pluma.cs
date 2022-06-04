using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEnumeadosTinta
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = new Tinta();
            this.cantidad = 0;
        }
        public Pluma(string marca)
        {
            this.marca = marca;
            this.tinta = new Tinta();
            this.cantidad = 0;
        }

        public Pluma(string marca, ConsoleColor  color)
        {
            this.marca =marca;
            this.tinta = new Tinta(color);
            this.cantidad = 0;
        }
        public Pluma(string marca, ConsoleColor color, ETipoTinta tipo)
        {
            this.marca = marca;
            this.tinta = new Tinta(color,tipo);
            this.cantidad = 0;
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (pluma.tinta == tinta)
            {
                pluma.cantidad++;
            }
            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma.tinta == tinta)
            {
                pluma.cantidad--;
            }
            return pluma;
        }
        public static implicit operator string(Pluma pluma)
        {
            return ("Pluma " + pluma.marca +" con " + Tinta.Mostrar(pluma.tinta) + "\nCantidad: " + pluma.cantidad);
        }
    }
}
