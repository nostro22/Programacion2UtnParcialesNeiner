using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPPLibreria
{
    public class Biografia : Publicacion
    {
        //property
        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

        public override bool HayStock
        {
            get
            {
                return (this.stock > 0);
            }
        }

        //Methods

        public Biografia(string nombre, int stock, float valor)
            : base(nombre, stock, valor) { }

        public Biografia(string nombre, int stock)
            : base(nombre, stock) { }
       

        public Biografia(String nombre)
            : base(nombre) { }

        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }
    }
}
