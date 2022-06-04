using System;

/*
 * Ejercicio I02 - Error al cubo
Consigna#
Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
 * */

namespace eje__2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables

            float numeroIngresado;
            double cuadradoNumero;
            double cuboNumero;
            numeroIngresado = ingresarNumeroPositivo();
            cuadradoNumero = Math.Pow(numeroIngresado,2);
            cuboNumero = Math.Pow(numeroIngresado, 3);
            Console.Clear();
            Console.WriteLine("Numero:{0} \nCuadrado:{1} \nCubo:{2}", numeroIngresado, cuadradoNumero, cuboNumero);
        }

        public static float ingresarNumeroPositivo()
        {
            string ingreso;

            Console.WriteLine("Ingrese un numero");
            ingreso = Console.ReadLine();

            if (float.TryParse(ingreso, out float numeroIngresado)&&float.Parse(ingreso)>0)
            {
                return numeroIngresado;
            }
            else
            {
                Console.WriteLine("Ingreso incorrecto profavor ingrese un numero positivo mayor a 0");
                return ingresarNumeroPositivo();
            }
        }
    }



}
