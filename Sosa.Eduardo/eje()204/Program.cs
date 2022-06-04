using System;

namespace eje__204
{
    class Program
    {
        static void Main(string[] args)
        {
            float primerOperando = 0;
            float segundoOperando = 0;
            float resultado = 0;
            string operacion;
            Console.WriteLine("Bienvenido podes realizar opreciones sencillas de suma, resta, multiplicacion y division");

            do
            {
                Validador.IngresarNumeroFlotante(ref primerOperando, "Ingrese el primer Operando", -1000, 1000);
                Validador.IngresarNumeroFlotante(ref segundoOperando, "Ingrese el segundo Operando", -1000, 1000);
                Console.WriteLine("Presione el simbolo de la operacion a realizar: \nsuma:+ \nresta:- \nmultiplicacion:*\ndivision:/");
                operacion = Console.ReadLine();
                resultado = Calculadora.Calcular(primerOperando, segundoOperando, operacion);
                Console.WriteLine("\n{0}{1}{2}={3}", primerOperando, operacion.ToString(), segundoOperando, resultado);
            } while (Validador.ValidarRespuesta());
       
        }



    }
}
