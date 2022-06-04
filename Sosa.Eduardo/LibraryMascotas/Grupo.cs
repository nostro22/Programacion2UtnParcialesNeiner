using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMascotas
{
    public class Grupo
    {
        //Campos

        private List<Mascota> manada;
        private string nombre;
        private static EtipoManada tipo;

        //Propiedades

        public EtipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }

        //Constructor
        static Grupo()
        {
            Grupo.tipo = EtipoManada.Unica;
        }
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }       

        public Grupo(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Grupo(String nombre, EtipoManada tipo):this(nombre)
        {
            this.Tipo = tipo;
        }
        //SobreEscritura

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Grupo: {g.nombre} - Tipo: {tipo.ToString()} \nIntegrantes ({g.manada.Count()}) ");

            foreach (Mascota item in g.manada)
            {                
                    sb.AppendLine(item.ToString());                         
            }

            return sb.ToString();
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g==m);
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            //return g.manada.Contains(m);    Valido solo si sobrecargamos los equals en todas las clases derivadas.
            bool retorno = false;
            
            foreach (Mascota unaMascota in g.manada)
            {
                if (unaMascota.Equals(m))
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g is Grupo && m is  Mascota && g == m)
            {
                g.manada.Remove(m);
            }
            else
            {
                Console.WriteLine($"No está el {m.ToString()}' en el grupo");
            }
            return g;
        }
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
            {
                g.manada.Add(m);
            }
            else
            {
                Console.WriteLine($"Ya está {m.ToString()}' en el grupo");
            }
            return g;
        }
    }
}
