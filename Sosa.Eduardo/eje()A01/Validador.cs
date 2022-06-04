using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje__A01
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

        public static bool IngresarNumeroFloat(ref float numeroVerificado, string mensaje, float limiteInferior, float limiteSuperior)
        {
            string ingreso;
            bool ingresoExitoso = false;
            do
            {
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
                if (double.TryParse(ingreso, out double numeroIngresado) && numeroIngresado > limiteInferior && numeroIngresado < limiteSuperior)
                {
                    numeroVerificado = float.Parse(ingreso);
                    ingresoExitoso = true;
                    break;
                }
                else if (ingreso.ToUpper() != "S")
                {
                    Console.WriteLine("Ingreso invalido...");
                }
            } while (ingreso.ToUpper() != "S");
            return ingresoExitoso;
        }

        public static bool IngresarNumeroEnteroPositivo(ref int numeroVerificado, string mensaje)
        {
            string ingreso;
            bool ingresoExitoso = false;

            do
            {
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();

                if (int.TryParse(ingreso, out int numeroIngresado) && numeroIngresado > 0)
                {
                    numeroVerificado = int.Parse(ingreso);
                    ingresoExitoso = true;
                    break;
                }
                else if (ingreso.ToUpper() != "S")
                {
                    Console.WriteLine("Ingreso invalido...");
                }
            } while (ingreso.ToUpper() != "S");

            return ingresoExitoso;

        }
    }

  

}
