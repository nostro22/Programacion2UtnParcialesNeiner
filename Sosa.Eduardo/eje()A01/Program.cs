using System;

namespace eje__A01
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingreso = 0;
            bool ingresoIsValid = false;
            double factorial = 0;
            ingresoIsValid = Validador.IngresarNumeroEnteroPositivo(ref ingreso, "Ingrese el numero entero positivo del factorial que desea calcular o 's' para salir");
            if(ingresoIsValid)
            {
                factorial = CalcularFactorial(ingreso);
                Console.WriteLine("El valor del factorial de {0} es:{1}", ingreso, factorial);
            }
        }
        static public double CalcularFactorial(int entero)
        {
            double factorial = 1;
            for (int i = 1; i <= entero; i++)
            {
                factorial *= (double)i;
            }
            return factorial;
        }

    }
}
