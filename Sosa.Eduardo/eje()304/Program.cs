using System;
using LibraryClase3;
namespace eje__304
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo bluePen = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo redPen = new Boligrafo(50, ConsoleColor.Red);
            string dibujo = string.Empty;
            Console.WriteLine("Boligrafo azul tinta:{0} de color {1} ", bluePen.GetTinta(), bluePen.GetColor());
            Console.WriteLine("Boligrafo rojo tinta:{0} de color {1} ", redPen.GetTinta(), redPen.GetColor());
            bluePen.Pintar(5, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine("Boligrafo azul tinta:{0} de color {1} ", bluePen.GetTinta(), bluePen.GetColor());
            bluePen.Recarga();
            Console.WriteLine("Boligrafo azul tinta:{0} de color {1} ", bluePen.GetTinta(), bluePen.GetColor());
        }

    }
}
