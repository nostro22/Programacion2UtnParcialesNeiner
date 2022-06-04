using System;

namespace eje__6
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicioPeriodo = 0;
            int finalPeriodo = 0;
            bool ingresoCorrecto = true;
            Console.WriteLine("Bienvenido al calculador de años bisiestro, ingrese dos fechas y calcularemos los años bisiesto dentro de ese periodo");
            Console.WriteLine("Ingrese primera fecha");
            ingresoCorrecto= IngresarNumeroEnteroPositivo(ref inicioPeriodo);
            if(ingresoCorrecto)
            {
                Console.Clear();
                Console.WriteLine("Ingrese segunda fecha");
                ingresoCorrecto = IngresarNumeroEnteroPositivo(ref finalPeriodo);
            }
            if(ingresoCorrecto)
            {
                ImprimirBisiestros(inicioPeriodo, finalPeriodo);
            }
            else
            {
                Console.WriteLine("Progama finalizado");
            }        
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

        public static bool IsBisiestro(int year)
        {
            bool isBisiestro = false;
            if(year>=400 && year%100==0 && year%400==0 && year%4==0)
            {
                isBisiestro = true;
            }
            else if (year%4==0 && year%100!=0)
            {       
                isBisiestro = true;   
            }            
            return isBisiestro;
        }

        public static void ImprimirBisiestros(int startYear, int endYear)
        {
            int fechaIntercambioTemporal;
            if(startYear>endYear)
            {
                fechaIntercambioTemporal = startYear;
                startYear = endYear;
                endYear = fechaIntercambioTemporal;
            }
            Console.WriteLine("Años Bisiestros:");
            for (int i = startYear; i <= endYear; i++)
            {
                if(IsBisiestro(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
