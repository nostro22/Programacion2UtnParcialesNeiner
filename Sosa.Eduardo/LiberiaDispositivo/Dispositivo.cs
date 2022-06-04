using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberiaDispositivo
{
    public static class Dispositivo
    {
        //fields

        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        //Methods

         static Dispositivo()
         {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
         }            

        public static  bool InstalarApp(Aplicacion app)
        {
            bool retorno = false;
            if (app.SistemaOperativo == Dispositivo.sistemaOperativo && appsInstaladas + app)
            {
               
                retorno = true;
            }
            return retorno;                         
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Sistema operativo: {sistemaOperativo}");
            foreach (Aplicacion item in appsInstaladas)
            {
                sb.AppendFormat("\n\n{0}", item.ObtenerInformacionApp());
            }

            return sb.ToString();        
        }


    }
}
