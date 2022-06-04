using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEjercicioIntegrador
{
    public class ParaisoFiscal
    {
        //fields

        private  List<CuentaOffShore> _listaCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;

        //methods

        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            ParaisoFiscal ParaisoFiscal = new ParaisoFiscal(epf);
            return ParaisoFiscal;
        }

        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();
       
              

            int cantidadParaisos = Enum.GetNames(typeof(eParaisosFiscales)).Length;
           
            for (int i = 0; i < cantidadParaisos ; i++)
            {
                eParaisosFiscales paraiso = (eParaisosFiscales)i;
                if (this._listaCuentas.Count > 0 && this._lugar == paraiso)
                {
                    sb.AppendLine($"\nFecha de Inicio : {ParaisoFiscal.fechaInicioActividades.Date}")
                   .AppendLine($"Locación: {this._lugar}")
                   .AppendLine($"Cantidad de cuentitas: {this._listaCuentas.Count}")
                   .AppendLine("********_listaCuentas de cuentas offshore******************");
                }           
                
                foreach (CuentaOffShore item in this._listaCuentas)
                {
                    if (this._lugar == paraiso)
                        sb.Append(item.Dueño.RetornarDatos())
                            .AppendLine($"Número de cuenta: {(int)item}")
                            .AppendLine($"Saldo: {item.Saldo}")
                            .AppendFormat("\n");
                }
            }

         

             Console.Write(sb.ToString());
        }

        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            foreach (CuentaOffShore item in pf._listaCuentas)
            {
                if (item == cos)
                {
                    return true;
                }
            }
            return false;

        }

        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            
            return !(pf == cos);
        }

        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf == cos)
            {
                pf._listaCuentas.Remove(cos);

                Console.WriteLine("Se quitó la cuenta del paraíso...");
                
            }
            else
            {
                Console.WriteLine("La cuenta no existe en el paraíso...");
            }
            return pf;

        }

        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf != cos)
            {
                pf._listaCuentas.Add(cos);
                Console.WriteLine("Se agregó la cuenta al praíso...");

            }
            else if (pf == cos)
            {

                foreach (CuentaOffShore item in pf._listaCuentas)
                {
                    if (item == cos)
                    {
                        item.Saldo += cos.Saldo;
                        Console.WriteLine("Se actualizo el saldo de la cuenta");
                        break;
                    }

                }
            }
          
            return pf;
        }

        private ParaisoFiscal()
        {
            this._listaCuentas = new List<CuentaOffShore>();
        }

        static ParaisoFiscal()
        {           
            cantidadDeCuentas = 0;
            fechaInicioActividades = DateTime.Now;
        }

        private ParaisoFiscal(eParaisosFiscales lugar):this()
        {
            this._lugar = lugar;
        }

    }
}
