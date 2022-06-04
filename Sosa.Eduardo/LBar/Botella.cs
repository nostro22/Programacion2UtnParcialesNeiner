using System;
using System.Text;

namespace Entidades.Botellas
{
    public abstract class Botella
    {
        //campos

        protected int capacidad;
        protected int contenido;
        protected string marca;
        protected double precio;

        //Propiedades

        public abstract double Ganancia
        {
            get;            
        }

        public double PorcentajeContenido
        {
            get
            {
                return this.contenido * 100 / this.capacidad;
            }
        }

        //methods

        public Botella(string marca, double precio):this(marca,precio,1000)
        {
           
        }

        public Botella(string marca, double precio, int capacidad)
        {
            this.marca = marca;
            this.precio = precio;
            this.capacidad = capacidad;
            this.contenido = capacidad;
            
        }

        public static explicit operator string(Botella a)
        {
            return a.marca;
        }

        private static string ObtenerDatos(Botella b)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + b.marca.ToUpper());
            sb.AppendLine($"Precio: ${ b.precio}");
            sb.AppendLine("Capacidad: " + b.capacidad);
            sb.AppendLine("Contenido: " + b.contenido);
            sb.AppendLine($"PorcentajeContenido: {b.PorcentajeContenido}");           
           
            return sb.ToString();

        }

        public static bool operator ==(Botella a, Botella b)
        {
            return (a is Botella && b is Botella && a.marca == b.marca && a.capacidad == b.capacidad);
            
        }

        public static bool operator !=(Botella a, Botella b)
        {
            return !(a == b);
        }

        public static Botella operator --(Botella a)
        {
            a.ServirMedida();
            return a;
        }

        protected abstract void ServirMedida();

        public override string ToString()
        {
            return Botella.ObtenerDatos(this);
        }

    }
}
