using System;

namespace eje__9
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingreso = 0;
            IngresarNumeroEnteroPositivo(ref ingreso);
            ImprimirArbolito(ingreso);
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

        public static void ImprimirArbolito(int altura)
        {
            int limite = -1;            
            for (int i = 0; i < altura; i++)
            {
                limite += 2;
                for (int k = altura-i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < limite; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
