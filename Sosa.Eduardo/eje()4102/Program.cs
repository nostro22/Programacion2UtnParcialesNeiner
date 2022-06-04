using System;
using Billetes;
namespace eje__4102
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar1 = new Dolar(100);
            Dolar dolar2 = new Dolar(50);
            Dolar dolar3 = new Dolar(1);

            Euro euro1 = new Euro(100);
            Euro euro2 = new Euro(50);
            Euro euro3 = new Euro(1);

            Peso peso1 = new Peso(100);
            Peso peso2 = new Peso(50);
            Peso peso3 = new Peso(1);

            #region Dolares 
            Console.WriteLine("Casteo a Dolar\nDolar->Dolar:{0}{1}{2}", dolar1.GetCantida(), dolar2.GetCantida(), dolar3.GetCantida());

            //euro1 = (Euro)dolar1;
            euro2 = (Euro)dolar2;
            euro3 = (Euro)dolar3;

            Console.WriteLine("Casteo a Dolar\nDolar->Euro:{0} || {1} || {2}",euro1.GetCantida(), euro2.GetCantida(), euro3.GetCantida());

            //peso1 = (Peso)dolar1;
            peso2 = (Peso)dolar2;
            peso3 = (Peso)dolar3;

            Console.WriteLine("Casteo a Dolar\nDolar->Peso:{0} || {1} || {2}", peso1.GetCantida(), peso2.GetCantida(), peso3.GetCantida());

            Console.WriteLine((dolar1 + dolar2 + dolar3).GetCantida());
            Console.WriteLine((dolar1 - dolar2 - dolar3).GetCantida());
            Dolar operaciones;
            operaciones = dolar1 + euro1+peso1;
            Console.WriteLine(operaciones.GetCantida());


            #endregion Dolares
        }
    }
}
