using System;

namespace eje__207
{
    class Program
    {
        static void Main(string[] args)
        {
            float ingresoBase = 0;
            float ingresoAltura = 0;
            float hipotenusa = 0;
            bool validInput = false;

            Console.WriteLine("Bienvenido al calculador de hipotenusa usando teorema de pitagoras");
           validInput = Validador.IngresarNumeroFloat(ref ingresoBase, "Ingrese la base del triangulo o s para salir", 1, 999);
           if(validInput)
            {
                validInput = Validador.IngresarNumeroFloat(ref ingresoAltura, "Ingrese la altura del triangulo  o s para salir", 1, 999);
                if (validInput)
                {
                    hipotenusa = MathF.Sqrt(MathF.Pow(ingresoBase, 2) + MathF.Pow(ingresoAltura, 2));
                    Console.WriteLine("La hipotenusa es:{0}", hipotenusa);
                }
            }
            else
            {
                Console.WriteLine("Cerrando Programa");
            }
          
        }
    }
}
