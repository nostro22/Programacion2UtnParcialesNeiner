using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces._2020
{
    public class Familiar : Auto
    {
        //fields

        protected int _cantAsientos;

        //methods

        public Familiar(double precio, string patente, int cantidadAsientos) : base(precio, patente)
        {
            this._cantAsientos = cantidadAsientos;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine($"Precio del Familiar: {this._precio}");
        }
        public override void MostrarPatente()
        {
            Console.WriteLine($"Patente del familiar: {this._patente}");
        }
    }
}
