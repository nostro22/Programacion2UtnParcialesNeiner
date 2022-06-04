using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje__5
{
    class Program
    {
        static void Main(string[] args)
        {
            int centroNumerico = 6;
            int limiteSuperior = 8;
            HallarCentro(limiteSuperior, ref centroNumerico);
            Console.WriteLine("El centro numerico es:{0}", centroNumerico);
        }

        public static bool IngresarNumeroEnteroPositivo(ref int numeroVerificado)
        {
            string ingreso;
            bool ingresoExitoso = false;

            do
            {
                Console.WriteLine("Ingrese un numero o 'S'  si desea salir del programa");
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

        public static void HallarCentro(int limiteSuperior,ref int centroNumerico)
        {
            int partA = 1;
            int partB = limiteSuperior-1;
            centroNumerico = 2;

            do
            {
                partA++;
                partB--;
                centroNumerico++;
            } while (partA != partB);

        }
    }
}
