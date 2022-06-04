using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPPLibreria
{
    public class Vendedor
    {
        //Fields
        private string nombre;
        private List<Publicacion> ventas;

        //Methods

        public static string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(vendedor.nombre.ToUpper());
            sb.AppendLine("--------------------------------------");
            float gananciaTotal = 0;
            foreach (Publicacion p in vendedor.ventas)
            {
                sb.Append(p.GetType().Name + ": ");
                sb.Append(p.ObtenerInformacion());
                sb.AppendLine("--------------------------------------");
                gananciaTotal += p.Importe;
            }
            sb.AppendLine($"Ganancia Total: ${gananciaTotal}");

            return sb.ToString();
        }

        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if (publicacion.HayStock)
            {
                publicacion.Stock--;
                vendedor.ventas.Add(publicacion);
                return true;
            }
            return false;
        }

        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }
    }
}
