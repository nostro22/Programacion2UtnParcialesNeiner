using System;

namespace eje__3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            ingresarNumeroEntero(ref numero);
            if (isPrimo(numero))
            {
                Console.WriteLine("El numero {0} es primo", numero);
            }
            else
            {
                Console.WriteLine("El numero {0} no es primo", numero);
            }
        }

        public static int ingresarNumeroEntero( ref int numeroVerificado)
        {
            string ingreso;
            
            do
            {
                Console.WriteLine("Ingrese un numero o 'S'  si desea salir del programa");
                ingreso = Console.ReadLine();

                if (int.TryParse(ingreso, out int numeroIngresado))
                {
                    numeroVerificado = int.Parse(ingreso);
                    return 1;
                }
                else if (ingreso.ToUpper()!="S")
                {
                    Console.WriteLine("Ingreso invalido...");
                }

            } while (ingreso.ToUpper() != "S");

            return 0;

        }

        public static bool isPrimo(int numero)        {

            numero = Math.Abs(numero);
            

            for (int i = numero-1; i > 1; i--)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }          

            return true;

        }

    }
}
