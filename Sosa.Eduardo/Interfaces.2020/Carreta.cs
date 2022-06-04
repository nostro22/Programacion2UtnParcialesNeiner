using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces._2020
{
    public class Carreta : Vehiculo, IARBA
    {
        //methods

        public Carreta(double precio) : base(precio) { }

        public double CalcularImpuesto()
        {
            return this._precio * 0.18;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine($"Precio de la carreta: {this._precio}");
        }

    }
}
