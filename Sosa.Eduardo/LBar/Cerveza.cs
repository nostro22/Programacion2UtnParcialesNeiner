using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public class Cerveza:Botella
    {
        //campos
        public int medida;
        public TipoCerveza tipo;

        //property

        public override double Ganancia
        {
            get
            {
                return ((3 - (int)(this.contenido / this.medida)) * this.precio * 0.5);
            }
        }

        //Methods

        public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo):this(marca,precio,capacidad,tipo,capacidad/3)
        {
        
        }
        public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo, int medida):base(marca,precio,capacidad)
        {
            this.tipo = tipo;
            this.medida = medida;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        

        public static bool operator ==(Cerveza a, Cerveza b)
        {
            return (a is Botella && b is Botella && a.tipo == b.tipo);
        }

        public static bool operator !=(Cerveza a, Cerveza b)
        {
            return !(a == b);
        }

        protected override void ServirMedida()
        {
            this.contenido -= this.capacidad / 3;
            if (this.contenido < 0)
            {
                this.contenido = 0;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Medida: " + this.medida);
            sb.AppendLine($"Tipo: {this.tipo}");
          

            return sb.ToString();
        }
    }
}
