using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            JUGUETE j1 = new JUGUETE("Lego", 7773);
            JUGUETE j2 = new JUGUETE("Matel", 3423);
            JUGUETE j3 = new JUGUETE("Ditoy", 2329);
            JUGUETE j4 = new JUGUETE("Toyco", 45443);

            CAJA<JUGUETE>.Agregar<JUGUETE>(j1);
            CAJA<JUGUETE>.Agregar<JUGUETE>(j2);
            CAJA<JUGUETE>.Agregar<JUGUETE>(j3);
            CAJA<JUGUETE>.lista = CAJA<JUGUETE>.Agregar<JUGUETE>(j4);

            Console.WriteLine(CAJA<JUGUETE>.Mostrar<JUGUETE>());
            Console.ReadKey();
        }
    }
}
