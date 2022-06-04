using System;

namespace eje__5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int centroNumerico = 0;
            int limiteSuperior=0;
            bool centerExist = false;
            bool ingresoExitoso = false;
            ingresoExitoso = IngresarNumeroEnteroPositivo(ref limiteSuperior);
            if(ingresoExitoso)
            {
                centerExist = HallarCentro(limiteSuperior, ref centroNumerico);
                if (centerExist)
                {
                    Console.WriteLine("El centro numerico entre el rango 1-{0} es:{1}", limiteSuperior, centroNumerico);
                }
                else
                {
                    Console.WriteLine("El centro numerico entre el rango 1-{0} no existe", limiteSuperior);
                }
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

        public static bool HallarCentro(int limiteSuperior, ref int centroNumerico)
        {
            int sumaIzquierda = 0;
            int sumaDerecha = 0;            
            bool centerExist = false;                     
            
            if(limiteSuperior>=6)
            {
                for (int i = 6; i < limiteSuperior; i++)
                {
                    sumaDerecha = 0;
                    sumaIzquierda = 0;
                    for (int j = i - 1; j > 0; j--)
                    {
                        sumaIzquierda += j;
                    }
                    for (int k = i + 1; k <= limiteSuperior; k++)
                    {
                        sumaDerecha += k;
                    }
                    if (sumaIzquierda == sumaDerecha)
                    {
                        centroNumerico = i;
                        Console.WriteLine(centroNumerico);
                        centerExist = true;
                        break;
                    }
                    else if (i == limiteSuperior - 1)
                    {
                        centerExist = false;
                    }
                }
            }
                  
            return centerExist;
        }
    }
}

