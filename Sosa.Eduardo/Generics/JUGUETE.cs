using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class JUGUETE
    {
        private string marca;
        public double precio;

        virtual public double Precios
        {
            get
            {
                return 2;
            }
        
        }

        public JUGUETE(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        private string Mostrar()
        {
            return $"Marca:{this.marca} \nPrecio:{this.precio} ";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
