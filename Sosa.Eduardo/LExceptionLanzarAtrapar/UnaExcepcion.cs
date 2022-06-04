using System;

namespace LExceptionLanzarAtrapar
{
    public class UnaExcepcion:Exception
    {
        public UnaExcepcion()
        : base("Mensaje de error base de UnaException")
        {
        }

        public UnaExcepcion(string mensaje)
            : base(mensaje)
        {
        }

        public UnaExcepcion(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }

        public UnaExcepcion(string mensaje, Exception innerException, string origenError)
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
