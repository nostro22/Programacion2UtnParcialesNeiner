using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public class Cerveza:Botella
    {
        //Campos 
        public int medida;
        public TipoCerveza tipo;

        //propiedades

        public override double Ganancia
        {
            get
            {
                double gananciaPerMedida = this.precio * 0.5;
                int medidasVendidas = (int)MathF.Ceiling((this.capacidad - this.contenido) / this.medida);
                return gananciaPerMedida*medidasVendidas;
            }
        }

        //Constructor

        public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo, int medida):base(marca,precio,capacidad)
        {
            this.tipo = tipo;
            this.medida = medida;
        }
        public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo)
            : this(marca, precio, capacidad,tipo,capacidad/3) {}

        //Metodos

        protected override void ServirMedida()
        {
            if (this.contenido> this.medida)
            {
                this.contenido -= this.medida;
            }
            else
            {
                this.contenido = 0;
            }          
        }

        //SobreEscritura

        public static bool operator ==(Cerveza a, Cerveza b)
        {
            return (a is Cerveza && b is Cerveza && (Botella)a == b && a.tipo == b.tipo);
        }

        public static bool operator !=(Cerveza a, Cerveza b)
        {
            return !(a == b);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            return (obj is Cerveza cerveza && this == cerveza);            
        }

        public override string ToString()
        {
            return $"Tipo de Cerveza: {this.tipo}\nMedida: {this.medida}\n{base.ToString()}";
        }
    }
}
