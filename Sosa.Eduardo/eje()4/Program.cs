using System;

namespace eje__4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingreso=0;
            bool ingresoExitoso;
            ingresoExitoso = ingresarNumeroEnteroPositivo(ref ingreso);
            
            if(ingresoExitoso)
            {
                if (isPerfectNumber(ingreso))
                {
                    Console.WriteLine("El numero {0} es un numero perfecto", ingreso);
                }
                else
                {
                    Console.WriteLine("El numero {0} no es un numero perfecto", ingreso);
                }
            }    
            
        }


        public static bool ingresarNumeroEnteroPositivo(ref int numeroVerificado)
        {
            string ingreso;
            bool ingresoExitoso=false;

            do
            {
                Console.WriteLine("Ingrese un numero o 'S'  si desea salir del programa");
                ingreso = Console.ReadLine();

                if (int.TryParse(ingreso, out int numeroIngresado) && numeroIngresado>0)
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

        public static bool isPerfectNumber(int numero)
        {
            int sumaDivisores = 0;
            bool isPerfect = false;

            for (int i = numero - 1; i > 0; i--)
            {                
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }
            if(sumaDivisores!=numero)
            {
                isPerfect = false;
            }
            else
            {
                isPerfect = true;
            }
            return isPerfect;

        }

    }
}
