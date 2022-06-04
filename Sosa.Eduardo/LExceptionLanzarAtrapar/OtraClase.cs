using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LExceptionLanzarAtrapar
{
    class OtraClase
    {

        public void unMetodoInstancia()
        {
            try
            {
                MiClase a = new MiClase("hola");
            }
            catch (UnaExcepcion e)
            {

                throw new MiExcepcion($"Mi excepcion lanzada desde otra clase", e);
            }
        }
       
    }
}
