using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInstrumentos
{
    class CasaDeMusica
    {
        private List<Instrumento> lista;
        private int cantidadMaxima;

        public CasaDeMusica()
        {
            this.lista = new List<Instrumento>();
        }
        public CasaDeMusica(int cantidadMaxima) : this()
        {
            this.cantidadMaxima = cantidadMaxima;
        }
        public List<Instrumento> Lista
        {
            get;
        }

        //Metodos

        public string Mostrar()
        {
            StringBuilder impresionLista = new StringBuilder();

            foreach (Instrumento item in this.Lista)
            {
                if (item is Guitarra)
                {
                    impresionLista.AppendLine(((Guitarra)item).MostrarGuitarra());
                }
                else if (item is Bateria)
                {
                    impresionLista.AppendLine(((Bateria)item).MostrarBateria());
                }
                else if (item is Trompeta)
                {
                    impresionLista.AppendLine(((Trompeta)item).MostrarTrompeta());
                }
                else if (item is Instrumento)
                {
                    impresionLista.AppendLine(item.Mostrar());
                }
            }
            return impresionLista.ToString();
        }

        public static bool operator ==(CasaDeMusica casaMusica, Instrumento instrumento)
        {
            bool retorno = false;
            foreach (Instrumento item in casaMusica.Lista)
            {
                if (item == instrumento)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(CasaDeMusica casaMusica, Instrumento instrumento)
        {
           
            return !(casaMusica==instrumento);
        }

        public static CasaDeMusica operator +(CasaDeMusica casaDeMusica, Instrumento intrumento)
        {     
            if (casaDeMusica != intrumento && casaDeMusica.Lista.Count>casaDeMusica.cantidadMaxima)
            {
                casaDeMusica.Lista.Add(intrumento);
            }
            return casaDeMusica;
        }



        public static CasaDeMusica operator -(CasaDeMusica casaDeMusica, Instrumento instrumento)
        {
            if (casaDeMusica == instrumento && casaDeMusica.Lista.Count < 0)
            {
                int indice = 0;
                foreach (Instrumento item in casaDeMusica.Lista)
                {
                    if (item == instrumento)
                    {
                        break;
                    }
                    indice++;
                }
                casaDeMusica.Lista.RemoveAt(indice);         
            }
            return casaDeMusica;
        }
    }
}
