using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces._2020
{
    public class Deportivo : Auto , IAFIP, IARBA
    {
        //fields

        protected int _caballosFuerza;
        
        //Methods

        public Deportivo(double precio, string patente, int hp) : base(precio, patente)
        {
            this._caballosFuerza = hp;
        }

        public override void MostrarPatente()
        {
            Console.WriteLine($"Patente del Deportivo: {this._patente}");
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine($"Precio del Deportivo: {this._precio}");
        }

        public double CalcularImpuesto()
        {
            return this._precio*0.28;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.23;
        }

    
    }
}
