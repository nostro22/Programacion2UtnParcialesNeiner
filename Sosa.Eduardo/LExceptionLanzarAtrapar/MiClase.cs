using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LExceptionLanzarAtrapar
{
    public class MiClase
    {


        public MiClase()
        {

            try
            {
                MiClase.MetodoEstatico();
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }

        public MiClase(string a)
        {
            try
            {
                MiClase miClase = new MiClase();
            }
            catch(DivideByZeroException e)
            {
                throw new UnaExcepcion("Excepcion con parametros unaExcepcion", e);
            }
        }
        public  static  void MetodoEstatico()
        {
            throw new DivideByZeroException("No se puede dividir por 0");
        }


    }
}
