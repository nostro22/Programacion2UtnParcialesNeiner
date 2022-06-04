using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInstrumentos
{
    class Trompeta:Instrumento
    {
        private string clave;

        public Trompeta(string clave, int codigo, string marca, EClasificacion clasificacion ):base(codigo,marca,clasificacion)
        {
            this.clave = clave;
        }
        public string MostrarTrompeta()
        {
            return new StringBuilder($"{this.Mostrar()} \nClave:{this.clave}").ToString();
        }

    }
}
