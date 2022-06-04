using System;
using LEnumeadosTinta;
namespace ConsoleAppEnumerados
{
    class Program
    {
        static void Main(string[] args)
        {
            Pluma plumaLisa = new Pluma();
            Pluma plumaMax = new Pluma("Max", ConsoleColor.Black, ETipoTinta.Comun);
            Tinta tintaNegraComun = new Tinta();

            Console.WriteLine((string)plumaLisa);
            Console.WriteLine((string)plumaMax);

            plumaMax = plumaMax + tintaNegraComun;
            Console.WriteLine((string)plumaMax);
            plumaMax = plumaMax - tintaNegraComun;
            Console.WriteLine((string)plumaMax);
        }
    }
}
