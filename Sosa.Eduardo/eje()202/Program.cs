using System;

namespace eje__202
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0;
            int ingresoParseInt = 0;
            string input="";
            Console.WriteLine("Bienvenido al sumador de numeros, ingrese numeros e iremos acumulado el total");

            do
            {
                Console.WriteLine("Ingrese el numero");
                input = Console.ReadLine();

                if (int.TryParse(input, out ingresoParseInt) && Validador.Validar(ingresoParseInt, -100, 100))
                {
                    suma += ingresoParseInt;
                }
                else
                {
                    Console.WriteLine("Ingreso invalido...");
                }
            } while (Validador.ValidarRespuesta());

            Console.WriteLine("\nTotal suma:{0}", suma);
            
        }
    }
}
