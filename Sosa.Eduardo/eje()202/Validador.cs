using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje__202
{
    class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor >= min && valor <= max)
            {
                return true;            
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarRespuesta()
        {
            ConsoleKey input;
           
            Console.WriteLine("¿Desea continuar? (S/N)");
            input = Console.ReadKey().Key;
            Console.WriteLine("");

            if ( input == ConsoleKey.S)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

  

}
