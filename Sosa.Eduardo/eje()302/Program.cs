using System;
using LibraryClase3;
namespace eje__302
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona edu = new Persona("edu",Convert.ToDateTime("31/03/2004"),95768450);
            Console.WriteLine( edu.EsMayorDeEdad());
        }
    }
}
