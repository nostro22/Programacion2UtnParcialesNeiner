using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero2016
{
    class Camion:Vehiculo
    {
        protected float tara;

        public Camion(string patente, Byte cantRuedas, EMarcas marca, float tara) : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Tara:{0}", this.tara);
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
