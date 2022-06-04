using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberiaDispositivo
{
    public class AppJuegos:Aplicacion
    {
        //property
        public static int test;
        public int noestatico;

       
        protected override int Tamanio
        {
            get
            {
                return this.tamanioMb;
            }
        }

        //methods

        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanio)
            : base(nombre, sistemaOperativo, tamanio) { }


  

    }
}
