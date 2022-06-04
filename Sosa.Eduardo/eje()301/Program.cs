using System;

using LibraryClase3;
namespace eje__301
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta eduardo = new Cuenta("eduardo", 1000);
            Cuenta tntGames = new Cuenta("tntGames", 2000);
            eduardo.Mostrar();
            tntGames.Mostrar();
            eduardo.ingresar(1000.22f);
            tntGames.retirar(500.50f);
            eduardo.Mostrar();
            tntGames.Mostrar();
        }
    }
}
