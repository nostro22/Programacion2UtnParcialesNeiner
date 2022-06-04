using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces._2020
{
   public static class Gestion
    {
        //methods

        public static double MostrarImpuestoNacional(IAFIP bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }

        public static double MostrarImpuestoProvincial(IARBA bienPunible)
        {
            return ((IARBA)bienPunible).CalcularImpuesto();
        }
    }
}
