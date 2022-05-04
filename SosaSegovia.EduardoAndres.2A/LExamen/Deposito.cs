using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades.Primer.Parcial
{
    public class Deposito
    {
        //Campos

        private int capacidad;
        private  List<Producto> productos;

        //Propiedades

        public double PrecioDeCelulares
        {
            get
            {

                double totalPrecio = 0;
                foreach (Producto item in this.productos)
                {
                    if (item is Celular)
                    {
                        totalPrecio += item.Precio;
                    }
                }
                return totalPrecio;

            }
        }
        public double PrecioDeTelevisores
        {
            get
            {
                double totalPrecio = 0;
                foreach (Producto item in this.productos)
                {
                    if (item is Televisor)
                    {
                        totalPrecio += item.Precio;
                    }
                }
                return totalPrecio;
            }
        }

        public double PrecioTotal
        {

            get
            {
                return (PrecioDeCelulares + PrecioDeTelevisores);
            }
        }

        //Methods

        private Deposito()
        {
            this.productos = new List<Producto>();
        }
        private Deposito(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public static implicit operator Deposito(int capacidad)
        {
            return new Deposito(capacidad);
        }

        public static string Mostrar(Deposito d)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Grupo: ({d.capacidad})");
            sb.AppendLine($"Total por televisores: ({d.ObtenerPrecio(EProducto.PrecioDeTelevisores)})");
            sb.AppendLine($"Total por celulares: ({d.ObtenerPrecio(EProducto.PrecioDeCelulares)})");
            sb.AppendLine($"Total: ({d.ObtenerPrecio(EProducto.PrecioTotal)})");
            sb.AppendLine("******************************");
            sb.AppendLine("Lista de celulares");
            sb.AppendLine("******************************");
            foreach (Producto item in d.productos)
            {
               
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        private double ObtenerPrecio(EProducto tipoProducto)
        {
            double precio = 0;
            if(tipoProducto == EProducto.PrecioDeCelulares)
            {
                precio = this.PrecioDeCelulares;
            }
            else if(tipoProducto == EProducto.PrecioDeTelevisores)
            {
                precio = this.PrecioDeTelevisores;
            }
            else if(tipoProducto == EProducto.PrecioTotal)
            {
                precio = this.PrecioTotal;
            }
            return precio;
        }
      
        public static bool operator !=(Deposito d, Producto p)
        {
            return !(d == p);
        }

        public static bool operator ==(Deposito d, Producto p)
        {
            if(p is not null)
            {
                foreach (Producto item in d.productos)
                {
                    if(item.Equals(p))
                    {
                        return true;
                    }
                }
            }


            return false;
        }



        public static Deposito operator +(Deposito d, Producto p)
        {
            if(d.capacidad>d.productos.Count)
            {
                if((p is Televisor && d!=p) || (p is Celular && d != p))
                {
                    d.productos.Add(p);
                }                
            }
            else
            {
                Console.WriteLine("El producto ya se encuentra en el deposito");
            }
            return d;
        }
    }
}
