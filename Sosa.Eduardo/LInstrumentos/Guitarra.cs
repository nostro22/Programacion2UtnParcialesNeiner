using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInstrumentos
{
    class Guitarra : Instrumento
    {
        public enum ETipoGuitarra
        {
            Clasica, Electrica
        }

        protected ETipoGuitarra Tipo
        {
            set;get;
        }


        private int cantidadDeCuerdas;


        public Guitarra(int codigo, string marca, int cantidadDeCuerdas, EClasificacion clasificacion, ETipoGuitarra tipo) : base(codigo,marca,clasificacion)
        {
            this.cantidadDeCuerdas = cantidadDeCuerdas;
            this.Tipo = tipo;
        }

        public Guitarra(EClasificacion clasificacion, ETipoGuitarra tipo, int cantidadDeCuerdas, string marca, int codigo) : base(codigo, marca, clasificacion)
        {
            this.cantidadDeCuerdas = cantidadDeCuerdas;
            this.Tipo = tipo;
        }

        public string MostrarGuitarra()
        {
            return new StringBuilder($"Tipo:{this.Tipo.ToString()} \n{this.Mostrar()} \nCantidad Cuerdas:{this.cantidadDeCuerdas}").ToString();
        }
    }
}
