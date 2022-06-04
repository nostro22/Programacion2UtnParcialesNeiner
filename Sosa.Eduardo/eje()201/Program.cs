using System;

namespace eje__201
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingresoParseInt = 0;           
            string input = "";
            int cantidaIngresoValidos = 0;
            int maximoIngreso=0;
            int minimoIngreso=0;
            float promedio = 0;            

            while (cantidaIngresoValidos < 10)
            {
                Console.WriteLine("Ingrese el {0} numero, recuerde que debe estar entre -100 y 100", cantidaIngresoValidos + 1);
                input = Console.ReadLine();

                if(int.TryParse(input,out ingresoParseInt) && Validador.Validar(ingresoParseInt,-100,100))
                {
                    if(cantidaIngresoValidos==0)
                    {
                        maximoIngreso = ingresoParseInt;
                        minimoIngreso = ingresoParseInt;                                             
                    }
                    else
                    {
                        if(maximoIngreso<ingresoParseInt)
                        {
                            maximoIngreso = ingresoParseInt;
                        }
                        if(minimoIngreso>ingresoParseInt)
                        {
                            minimoIngreso = ingresoParseInt;
                        }
                    }
                    promedio += ingresoParseInt;
                    cantidaIngresoValidos++;
                }
                else
                {
                    Console.WriteLine("Ingreso invalido...");
                }

            }
            promedio = promedio / 10;
            Console.WriteLine("Minimo ingresado:{0} \nMaximo ingresado:{1} \nPromedio:{2}", minimoIngreso, maximoIngreso, promedio);
        }
    }
}
