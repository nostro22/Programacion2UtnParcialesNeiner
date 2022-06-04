using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje__203
{
    class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroBinarioInverso = "";
            string numeroBinario = "";
            int residuo = numeroEntero;
            while (residuo>0)
            {
                numeroBinarioInverso += (residuo % 2).ToString();
                residuo = residuo / 2;
            }   
            for (int i = numeroBinarioInverso.Length-1; i >= 0; i--)
            {
                numeroBinario += numeroBinarioInverso[i];               
            }
            return numeroBinario;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string arrayBinario = "";
            string arrayBinarioInverso = "";
            int numeroEnteroObtenido = 0;
            arrayBinario = numeroEntero.ToString();
           
            for (int i = arrayBinario.Length - 1; i >= 0; i--)
            {
                arrayBinarioInverso += arrayBinario[i];
            }
            for (int i = 0; i < arrayBinarioInverso.Length ; i++)
            { 
                if(arrayBinarioInverso[i]=='1')
                {
                    numeroEnteroObtenido += (int)MathF.Pow(2, i);
                }              
            }
            return numeroEnteroObtenido;
        }

    }
}
