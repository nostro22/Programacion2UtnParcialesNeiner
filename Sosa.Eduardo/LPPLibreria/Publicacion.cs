using System;
using System.Text;

namespace LPPLibreria
{
    public abstract class Publicacion
    {
        //fields

        protected float importe;
        protected string nombre;
        protected int stock;

        //Properties

        protected abstract bool EsColor { get; }

        public virtual bool HayStock
        {
            get
            {
                return (this.stock > 0 && this.importe > 0);
            }
        }

        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value > 0)
                {
                    this.stock = value;
                }
            }
        }

        //Methods

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: " + this.nombre.ToUpper());
            sb.AppendLine($"Stock: {this.stock}");
            if (this.EsColor)
            {
                sb.AppendLine("Es color: SI");
            }
            else
            {
                sb.AppendLine("Es color: NO");
            }
            sb.AppendFormat("Valor: ${0}",this.importe);

            return sb.ToString();
        }

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock)
            : this(nombre)
        {
            Stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe)
            : this(nombre, stock)
        {
            this.importe = importe;
        }

        public override string ToString()
        {
            return this.nombre;
        }


    }
}
