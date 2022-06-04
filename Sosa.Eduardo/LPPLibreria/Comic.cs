using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPPLibreria
{
    public class Comic : Publicacion
    {
        //fields

        private  bool esColor;

        //property

        protected override bool EsColor
        {
            get
            {
               return this.esColor;
            }
        }

        //Methods

        public Comic(String nombre, bool esColor, int stock, float valor) : base(nombre, stock, valor)
        {
            this.esColor = esColor;            
        }
    }
}
