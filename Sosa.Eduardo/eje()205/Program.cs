using System;
using System.Text;

namespace eje__205
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingreso=0;
            int resultado = 0;

            if(IngresarNumeroEntero(ref ingreso))
            {
                Console.WriteLine("Tabla de multiplicar del número {0}", ingreso);

                for (int i = 1; i < 10; i++)
                {
                    StringBuilder tablaAux = new StringBuilder("n x i = r", 50);
                    resultado = i * ingreso;
                    tablaAux.Replace("n", Convert.ToString(ingreso));
                    tablaAux.Replace("i", Convert.ToString(i));
                    tablaAux.Replace("r", Convert.ToString(resultado));
                    Console.WriteLine(tablaAux);
                }
            }
            Console.WriteLine("Pregrama cerrado");         
        }

        public static bool IngresarNumeroEntero(ref int numeroVerificado)
        {
            string ingreso;
            bool ingresoExitoso = false;

            do
            {
                Console.WriteLine("Ingrese un numero o 'S'  si desea salir del programa");
                ingreso = Console.ReadLine();

                if (int.TryParse(ingreso, out int numeroIngresado))
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
