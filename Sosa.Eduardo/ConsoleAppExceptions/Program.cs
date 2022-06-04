using System;
using LExceptionLanzarAtrapar;
namespace ConsoleAppExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                MiClase a = new MiClase("hola");
            }
            catch (Exception ex)
            {

                MiExcepcion mi =  new MiExcepcion("ex",ex);

                UnaExcepcion una = new UnaExcepcion();
            }
            
        }
    }
}
