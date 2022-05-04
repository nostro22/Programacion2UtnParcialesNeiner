using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public abstract class Producto
    {
        //campos

        protected Fabricante fabricante;
        protected static Random generadorDePrecios;
        protected string modelo;
        protected double precio;

        //Propiedades

        public double Precio
        {
            get
            {
                if(this.precio==0)
                {                   
                    int parteEntera = 0;
                    double parteDecimal = 0;
                    parteEntera = Producto.generadorDePrecios.Next(10500, 12499);
                    parteDecimal = Producto.generadorDePrecios.NextDouble();
                                        
                    return this.precio = (double)parteEntera + parteDecimal;
                }
                else
                {
                    return this.precio;
                }
               
            }
        }

        //Methods

        public static explicit operator String(Producto p)
        {
            return Producto.Mostrar(p);
        }

        private static string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fabricante: "+(string)(p.fabricante));
            sb.AppendLine("Modelo: " + p.modelo);
            sb.Append($"Precio: {p.Precio}");            

            return sb.ToString();
        }

        public static bool operator ==(Producto a, Producto b)
        {
            return (a is not null && b is not null && a.fabricante == b.fabricante && a.modelo == b.modelo);
        }



        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

        static Producto()
        {
            Random r = new Random();
            Producto.generadorDePrecios = r;
 
        }

        public Producto(string modelo, Fabricante fabricante)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
        }

        public Producto(string modelo, string marca, EPais pais):this(modelo,new Fabricante(marca, pais))
        {           
        }


    }
}
