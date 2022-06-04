using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces._2020
{
    public class Privado : Avion
    {
        //fields

        protected int _valoracionServicioDeAbordo;

        //methods

        public Privado(double precio, double velocidad, int valoracion) : base(precio, velocidad)
        {
            this._valoracionServicioDeAbordo = valoracion;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Tipo:Privado");
            base.MostrarPrecio();
        }
    }
}
