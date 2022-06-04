using System;

namespace eje__7
{
    class Program
    {
        static void Main(string[] args)
        {
            string resumen= "";
            System.ConsoleKey continuar;
            do
            {
                PedirEmpleado(ref resumen);
                Console.WriteLine("Presione y si desea agregar otro empleado o cualquier otra tecla para imprimir la lista de los empleados");
                continuar =Console.ReadKey().Key;
            } while (continuar==ConsoleKey.Y);         

            Console.WriteLine(resumen);
        }

        public static bool IngresarNumeroEnteroPositivo(ref float numeroVerificado, string mensaje , float limiteInferior, float limiteSuperior)
        {
            string ingreso;
            bool ingresoExitoso = false;
            do
            {
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
                if (float.TryParse(ingreso, out float numeroIngresado) && numeroIngresado > limiteInferior && numeroIngresado<limiteSuperior)
                {
                    numeroVerificado = float.Parse(ingreso);
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

        public static void PedirEmpleado( ref string resumen)
        {
            string nombre="";
            float valorHora=0;
            float cantidadHoras=0;
            float antiguedad=0;
            float totalBruto=0;
            float totalNeto = 0;

            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();

            IngresarNumeroEnteroPositivo(ref valorHora, "Ingrese el precio por hora del empleado ", 0, 1000);
            IngresarNumeroEnteroPositivo(ref cantidadHoras, "Ingrese la cantidad de hora trabajas en el mes", 0, 720);
            IngresarNumeroEnteroPositivo(ref antiguedad, "Ingrese los años de antiguedad del empleado", 0, 120);

            totalBruto = (cantidadHoras * valorHora) + 150 * antiguedad;
            totalNeto = totalBruto * (float)0.87;
            resumen += ("nombre:"+nombre+"//antiguedad:"+antiguedad+"//Salario por hora:"+valorHora+"//Horas trabajadas:"+cantidadHoras+"//Total Cobrar bruto:"+totalBruto+"// Total Cobrar Neto:"+totalNeto+"\n");

        }
    }
}
