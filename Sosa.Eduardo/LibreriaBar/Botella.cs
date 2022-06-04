using System;
using System.Text;

namespace Entidades
{
    namespace Botellas
    {
        public abstract class Botella
        {
            //campos

            protected int capacidad;
            protected int contenido;
            protected string marca;
            protected double precio;


            //propiedas

            public abstract double Ganancia
            {
                get ;
            }
           

            public double PorcentajeContenido
            {
                get
                {
                    double porcentaje = this.contenido*100/this.capacidad;
                    return porcentaje;
                }
            }

            //Constructor

            public Botella(string marca, double precio, int capacidad)
            {
                this.marca = marca;
                this.precio = precio;
                this.capacidad = capacidad;
                this.contenido = capacidad;
            }
            public Botella(string marca, double precio)
                : this(marca, precio, 1000) { }

            //Metodos

            private string ObtenerDatos(Botella b)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Capacidad de la botella: {b.capacidad}");
                sb.AppendLine($"Contenido: {b.contenido}");
                sb.AppendLine($"Marca: {b.marca}");
                sb.AppendLine($"Precio: {b.precio}");
                sb.AppendLine($"Ganancia: {b.Ganancia}");

                return sb.ToString();
            }

            protected abstract void ServirMedida();

            //OverWrite
            public static explicit operator string(Botella a)
            {
                return a.ObtenerDatos(a);
            }

            public static bool operator ==(Botella a, Botella b)
            {
                bool retorno = false;
                if (a is Botella && b is Botella && a.capacidad == b.capacidad && a.marca == b.marca)
                {
                    retorno = true;
                }
                return retorno;
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

            public override string ToString()
            {
                return (string)this;
            }
        }

    }

    
}
