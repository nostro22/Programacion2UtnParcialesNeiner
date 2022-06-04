using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje__5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int centroNumerico = 0;
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

        public static bool HallarCentro(int limiteSuperior, ref int centroNumerico)
        {
            int sumaIzquierda = 0;
            int sumaDerecha = 0;
            centroNumerico = 0;
            bool centerExist = false;

            for (int i = 6; i < limiteSuperior; i++)
            {
                for (int j = i - 1; j > 0; j--)
                {
                    sumaIzquierda += j;
                }
                for (int j = i + 1; j < limiteSuperior; j++)
                {
                    sumaDerecha += j;
                }
                if (sumaIzquierda == sumaDerecha)
                {
                    centroNumerico = i;
                    centerExist = true;
                    break;
                }
                else if (i == limiteSuperior - 1)
                {
                    centerExist = false;
                }
            }
            return centerExist;
        }
    }
}
