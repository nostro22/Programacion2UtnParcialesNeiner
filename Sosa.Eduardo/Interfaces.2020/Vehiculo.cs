using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces._2020
{
    public abstract class Vehiculo
    {
        //fields

        protected double _precio;

        //methods

        public abstract void MostrarPrecio();
        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
    }
}
