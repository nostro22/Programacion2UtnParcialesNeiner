using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces._2020
{
    public class Comercial : Avion
    {
        //fields

        protected int _capacidadPasajeros;

        public override double ImpuestoArba
        {
            get
            {
                return 0.25;
            }
        }

        //methods

        public Comercial(double precio, double velocidad, int pasajeros) : base(precio, velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }


    }
}
