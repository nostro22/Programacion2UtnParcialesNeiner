using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LExceptionLanzarAtrapar
{
    public class MiExcepcion: Exception
    {

        public MiExcepcion()
         : base("Mensaje de error base de MiClaseException")
        {
        }

        public MiExcepcion(string mensaje)
            : base(mensaje)
        {
        }

        public MiExcepcion(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }

        public MiExcepcion(string mensaje, Exception innerException, string origenError)
            : base(mensaje, innerException)
        {
            base.Source = origenError;
        }

        public override string ToString()
        {
            return "Mensaje de error: " + base.InnerException.Message + "\nOrigen: " + base.Source;
        }

    }
}
