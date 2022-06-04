using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces._2020
{
    public abstract class Auto : Vehiculo
    {
        //fields

        protected string _patente;

        //methods

        public Auto(double precio, string patente) : base(precio)
        {
            this._patente = patente;
        }

        public abstract void MostrarPatente();
    }
}
