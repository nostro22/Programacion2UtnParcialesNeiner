using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Botellas;

namespace Entidades.Establecimiento
{
    public class Bar
    {
        //campos

        private List<Botella> botellas;
        private int capacidadMaximaBotellas;
        private string nombre;
        private double recaudacion;

        //propiedades

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        public string MostrarBar
        {
            get
            {
                return this.Mostrar();
             
            }
        }

    

        //methods

        public Bar():this(5,"Sin nombre")
        {
        
        }

        public Bar(int capacidad):this(capacidad,"Sin nombre")
        {
        
        }

        public Bar(int capacidad, string nombre)
        {
            this.capacidadMaximaBotellas = capacidad;
            this.nombre = nombre;
            this.botellas = new List<Botella>();
        }

        public static explicit operator Double(Bar b)
        {
            
            return b.recaudacion;
        }

        private string Mostrar()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre.ToUpper());
            sb.AppendLine($"Capacidad Maxima de Botellas: {this.capacidadMaximaBotellas}");
            sb.AppendLine($"Recaudacion: {(double)this}");
            foreach (Botella item in this.botellas)
            {
                sb.AppendLine(item.ToString());                
            }           

            return sb.ToString();
        }

        public static bool operator ==(Bar a, Botella b)
        {
            foreach (Botella item in a.botellas)
            {
                if (item == b)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Bar a, Botella b)
        {
            return !(a == b);
        }

        public static Bar operator -(Bar a, Botella b)
        {

            if (a == b)
            {
                b--;
                a = a + b.Ganancia;
                if (b.PorcentajeContenido == 0)
                {
                    a.botellas.Remove(b);
                }
            }

            return a;
        }
        public static Bar operator +(Bar a, Botella b)
        {
            if (a.capacidadMaximaBotellas > a.botellas.Count)
            {
                if (a != b)
                {
                    a.botellas.Add(b);
                }
            
            }

            return a;
        }
        public static Bar operator +(Bar a, double g)
        {
            a.recaudacion += g;
            return a;
        }

        public void OrdenarBotellas(Ordenamiento orderElegido)
        {
            if (orderElegido == Ordenamiento.Ganancia)
            {
                this.botellas.Sort(OrdenarPorGanancia);
            }

            if (orderElegido == Ordenamiento.Marca)
            {
                this.botellas.Sort(ordenarPorMarca);

            }

            if (orderElegido == Ordenamiento.PorcentajeContenido)
            {
                this.botellas.Sort(OrdenarPorContenido);

            }
        }

        public static int OrdenarPorContenido(Botella a, Botella b)
        {
            int retorno = 0;

            if (a.PorcentajeContenido > a.PorcentajeContenido)
            {
                retorno = 1;
            }

            if (a.PorcentajeContenido < a.PorcentajeContenido)
            {
                retorno = -1;
            }

            return retorno;
        }


        public int ordenarPorMarca(Botella a, Botella b)
        {
            return String.Compare((string)a, (string)b);
        }


        public int OrdenarPorGanancia(Botella a, Botella b)
        {
            int retorno = 0;

            if (a.Ganancia > a.Ganancia)
            {
                retorno = 1;
            }

            if (a.Ganancia < a.Ganancia)
            {
                retorno = -1;
            }

            return retorno;
        }


    }
}
