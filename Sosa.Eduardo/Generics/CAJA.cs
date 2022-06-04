using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class CAJA<T>
    {
        
        public static List<T> lista;

     
        static CAJA()
        {
            lista = new();
        }

        public static string Mostrar<X>() where X : T
        {
            System.Text.StringBuilder sb = new StringBuilder();
            foreach (T item in lista)
            {
                sb.AppendLine( item.ToString());
            }
            return sb.ToString();
        }

        public static List<T> Agregar<G>(G param2) where G : T
        {
            lista.Add(param2);
            return lista;
        }
           

    }
}
