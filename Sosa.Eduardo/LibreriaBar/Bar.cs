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
        //Campos

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

        //Constructores

        public Bar(int capacidad, string nombre)
        {
            this.botellas = new List<Botella>();
            this.capacidadMaximaBotellas = capacidad;
            this.nombre = nombre;
        }

        public Bar(int capacidad)
            : this(capacidad, "Sin nombre") { }

        public Bar()
            : this(5, "Sin nombre") { }

        //Metodos

        public static explicit operator Double(Bar a)
        {
            return a.recaudacion;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Capacidad: {this.capacidadMaximaBotellas}");
            sb.AppendLine($"Recaudacion: {this.recaudacion}\n");
            foreach (Botella unaBotellaDelBar in this.botellas)
            {
                sb.AppendLine(unaBotellaDelBar.ToString());
            }

            return sb.ToString();
        }

        public static bool operator ==(Bar a, Botella b)
        {
            bool retorno = false;
            foreach (Botella item in a.Botellas)
            {
                if (item == b)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Bar a, Botella b)
        {
            return !(a==b);
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
            
                if (a != b && a.capacidadMaximaBotellas>a.botellas.Count())
                {
                    a.botellas.Add(b);                    
                }
            
            return a;
        }

        public static Bar operator +(Bar a, double g)
        {
            a.recaudacion += g;
            return a;
        }

        public void OrdenarBotellas(Ordenamiento o)
        {
           
            switch (o)
            {
                case Ordenamiento.Marca:
                    this.Botellas.Sort(OrdenarPorMarca);
                    break;
                case Ordenamiento.Ganancia:
                    this.Botellas.Sort(OrdenarPorGanancia);
                    break;
                case Ordenamiento.PorcentajeContenido:
                    this.Botellas.Sort(OrdenarPorContenido);
                    break;               
            }            
        }

        private int OrdenarPorContenido(Botella a, Botella b)
        {
            int retorno = 0;
            if (a.PorcentajeContenido < b.PorcentajeContenido)
            {
                retorno = 1;
            }
            else if (a.PorcentajeContenido > b.PorcentajeContenido)
            {
                retorno = -1;
            }
            return retorno;
        }

        private int OrdenarPorGanancia(Botella a, Botella b)
        {
            int retorno = 0;
            if (a.Ganancia < b.Ganancia)
            {
                retorno = 1;
            }
            else if (a.Ganancia > b.Ganancia)
            {
                retorno = -1;
            }
            return retorno;
        }

        private int OrdenarPorMarca(Botella a, Botella b)
        {
            int retorno = 0;
            retorno = string.Compare(a.ToString(), b.ToString());
            return retorno;
        }
    }
}
