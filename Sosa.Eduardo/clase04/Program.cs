using System;

namespace clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cosa prueba = new Cosa();
            prueba.EstablecerValor("string assignado");
            prueba.EstablecerValor(22);
            prueba.EstablecerValor(DateTime.Now);
            Console.WriteLine(Cosa.Mostrar(prueba));
            
        }
    }
}
