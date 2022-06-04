using System;
using L4Sobrecarga;
namespace eje__4101
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(1);
            Sumador s2 = new Sumador(5);
            //1

            Console.WriteLine((int)s2);

            //2

            Console.WriteLine(s1 + s2);

            //3

            Console.WriteLine(s1 | s2);

            Console.WriteLine("Cantidad De sumas Realizadas :"+(int)s1);
            Console.WriteLine(s1.Sumar(21, 22));
            Console.WriteLine(s1.Sumar("21", "22"));
            Console.WriteLine("Cantidad De sumas Realizadas :" + (int)s1);






        }
    }
}
