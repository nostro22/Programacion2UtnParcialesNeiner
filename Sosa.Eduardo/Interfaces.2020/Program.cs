using System;

namespace Interfaces._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deportivo depo = new Deportivo(100, "adc", 200);
            Privado priva = new Privado(100, 100, 80);
            Comercial come = new Comercial(100, 100, 2);

            depo.MostrarPrecio();
            Console.WriteLine(depo.CalcularImpuesto());
            Console.WriteLine(((IARBA)depo).CalcularImpuesto());
            depo.MostrarPatente();


            Console.WriteLine("Privado");
            Console.WriteLine(priva.CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestoNacional(priva));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(priva));
            Console.WriteLine(((IARBA)priva).CalcularImpuesto());

            Console.WriteLine("Comerciales");
            Console.WriteLine(come.CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestoNacional(come));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(come));
            Console.WriteLine(((IARBA)come).CalcularImpuesto());
        }
    }
}
