using System;
using System.Text;

namespace LInstrumentos
{
    public class Instrumento
    {
        public enum EClasificacion
        {
            Cuerdas, Viento, percucion
        }

        protected EClasificacion Clasificacion
        {
            get; set;
        }

        protected int codigo;
        protected string marca;

        public Instrumento(int codigo, string marca)
        {
            this.codigo = codigo;
            this.marca = marca;
        }
        public Instrumento(int codigo, string marca, EClasificacion clasificacion) : this(codigo, marca)
        {
            this.Clasificacion = clasificacion;
        }

        ///metodos

        public string Mostrar()
        {
            return new StringBuilder($"{this.Clasificacion.ToString()} \nCodigo:{this.codigo} \nMarca:{this.marca}").ToString();
        }

        public static bool operator ==(Instrumento instrumetoUno, Instrumento instrumentoDos)
        {
            bool retorno = false;
            if(instrumetoUno.marca == instrumentoDos.marca && instrumetoUno.codigo == instrumentoDos.codigo && instrumetoUno.Clasificacion == instrumentoDos.Clasificacion)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Instrumento instrumetoUno, Instrumento instrumentoDos)
        {
            return !(instrumetoUno == instrumentoDos);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }



    }


}
