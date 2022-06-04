using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero2016
{
    class Auto : Vehiculo
    {

        protected int cantidadAsientos;

        public Auto(string patente, Byte cantRuedas, EMarcas marca, int cantidadAsientos) : base(patente, cantRuedas, marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Asientos:{0}", this.cantidadAsientos);
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
