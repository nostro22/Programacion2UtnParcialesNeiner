using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase04
{
    class Cosa
    {
        #region parametros

        private int entero;
        private string cadena;
        private DateTime fecha;

        #endregion parametros;

        #region metodos

        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        

        private string Mostrar()
        {
            string parametros =(this.entero +"\n" + this.cadena + "\n" + this.fecha.ToShortDateString());
            return parametros;
        }
        public static string Mostrar(Cosa cosaInstanciada)
        {

            return cosaInstanciada.Mostrar();
        }

        #endregion metodos;
    }
}
