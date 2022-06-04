using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces._2020
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        //fields

        protected double _velocidadMaxima;

      public virtual double ImpuestoArba
      {
            get 
            {
                return 0.27;
            }
             
      }

        //methods

        public Avion(double precio, double velMax): base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio*ImpuestoArba;            
        }

        public double  CalcularImpuesto()
        {
                return this._precio * 0.33;            
        }


        public override void MostrarPrecio()
        {
            Console.WriteLine($"Precio del avion: {this._precio}");
        }
    }
}
