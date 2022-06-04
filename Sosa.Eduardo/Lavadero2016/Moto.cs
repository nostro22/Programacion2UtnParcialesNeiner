using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero2016
{
    class Moto:Vehiculo
    {
        protected float cilindrada;

        public Moto(string patente, Byte cantRuedas, EMarcas marca, float cilindrada) :base(patente,cantRuedas,marca)
        {
            this.cilindrada = cilindrada;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca:{0} \nPatente:{1} \nRuedas:{2}", this.Marca, this.patente, this.cantRuedas.ToString());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
