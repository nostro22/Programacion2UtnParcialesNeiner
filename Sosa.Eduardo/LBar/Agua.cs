using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public class Agua:Botella
    {
        //campos

        public TipoAgua tipo;

        //propiedades

        public override double Ganancia
        {
            get
            {
                return this.precio * 1.25;
            }
        }

        //methods

        public Agua(string marca, double precio, int capacidad, TipoAgua tipo):base(marca,precio,capacidad)
        {
            this.tipo = tipo;            
        }

        public Agua(string marca, double precio, TipoAgua tipo):this(marca,precio,500,tipo)
        {
        
        }

        public override bool Equals(object obj)
        {
            return (obj is Agua unAgua && unAgua.tipo == this.tipo && this == (Botella)obj);
        }

        public static bool operator ==(Agua a, Agua b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Agua a, Agua b)
        {
            return !(a == b);
        }

        protected override void ServirMedida()
        {
            this.contenido = 0;
        }

        public override string ToString()
        {
            return (base.ToString() + $"\nTipo: {this.tipo}");
        }
    }
}
