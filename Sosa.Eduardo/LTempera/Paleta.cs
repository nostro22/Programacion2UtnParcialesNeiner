using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTempera
{
   public class Paleta
    {
        private List<Tempera> temperas;
        private int cantidadMaximaColores;

        private Paleta()
        {
            this.temperas = new List<Tempera>();
        }

        public Paleta(int cantidaMaximaC):this()
        {
            this.cantidadMaximaColores = cantidaMaximaC;
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        private string Mostrar()
        {
            StringBuilder impresion = new StringBuilder();
            impresion.AppendFormat("Paleta con capacidad de {0} con colores:", this.cantidadMaximaColores);
            foreach (Tempera item in this.temperas)
            {
                impresion.Append(item.Mostrar(item));
            }
            return impresion.ToString();
        }

        private int ObtenerIndice(Tempera temperaGuia)
        {
            int indice = -1;

            if (this.temperas.Contains(temperaGuia))
            {
                indice = this.temperas.ElementAt(temperaGuia);
            }
            return indice;
        }

        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static bool operator ==(Paleta p1, Tempera tempera)
        {
            bool isSame = false;
            if (p1.temperas.Contains(tempera))
            {
                isSame = true;
            }
            return isSame;
        }
        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta==tempera);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Tempera)
            {
                retorno = this == ((Tempera)obj);
            }
            return retorno;
        }

        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            Paleta resultado = new Paleta(1);
            if (paleta is Paleta)
            {
              resultado = paleta;
                if (paleta == tempera)
                {
                    int indice = paleta.ObtenerIndice(tempera);
                    paleta.temperas[indice] += tempera;
                    resultado = paleta;
                }
                else if (paleta != tempera && paleta.cantidadMaximaColores > paleta.temperas.Count)
                {
                    paleta.temperas.Add(tempera);
                    resultado = paleta;
                }
            }
                   
            return resultado;
        }

        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            Paleta resultado = new Paleta(1);
            if (paleta is Paleta)
            {
                resultado = paleta;
                if (paleta == tempera)
                {
                    int indice = paleta.ObtenerIndice(tempera);
                    int cantidadResultante = paleta.temperas[indice].Cantidad -tempera.Cantidad;
                    if (cantidadResultante <= 0)
                    {
                        paleta.temperas.RemoveAt(indice);
                    }
                    else
                    {
                        paleta.temperas[indice].Cantidad=indice;
                    }
                    resultado = paleta;
                }             
            }

            return resultado;
        }

        public static Paleta operator +(Paleta paleta, Paleta paleta2)
        {
            Paleta resultado = new Paleta(1);
            int indicePrimeraPaleta;
            int indiceSegundaPaleta;
            if (paleta is Paleta && paleta2 is Paleta)
            {
                resultado = paleta;
                foreach (Tempera tempera1 in paleta.temperas)
                {
                    foreach (Tempera temperas2 in paleta2.temperas)
                        if (tempera1 == temperas2)
                        {
                            indicePrimeraPaleta = paleta.temperas.IndexOf(tempera1);
                            indiceSegundaPaleta = paleta2.temperas.IndexOf(temperas2);
                            paleta.temperas[indicePrimeraPaleta] = tempera1 + temperas2;
                        }                   
                        else if (paleta.cantidadMaximaColores>paleta.temperas.Count)
                        {
                            paleta.temperas.Add(temperas2);
                        }
                }
                resultado = paleta;
            }
            return resultado;
        }
    }
}
