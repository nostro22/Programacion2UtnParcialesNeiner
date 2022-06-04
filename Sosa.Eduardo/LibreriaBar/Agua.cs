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
                return this.precio*1.25;
            }
        }

        //Constructor

        public Agua(string marca, double precio, int capacidad, TipoAgua tipo):base(marca,precio,capacidad)
        {
            this.tipo = tipo;
        }

        public Agua(string marca, double precio, TipoAgua tipo)
            : this(marca, precio, 500, tipo) { }

        //Metodo

        protected override void ServirMedida()
        {
            this.contenido = 0;
        }

        //Sobreescritura
        public static bool operator ==(Agua a, Agua b)
        {
            return (a is Agua && b is Agua && (Botella)a == b);           
        }
        public static bool operator !=(Agua a, Agua b)
        {
            return !(a==b);
        }
   
        public override bool Equals(object obj)
        {
            return (obj is Agua botellaAgua && botellaAgua == this);
        }
    

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());            
            sb.AppendLine($"Tipo: {this.tipo}");

            return sb.ToString();

        }
    }
}
