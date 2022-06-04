using System;
using LEnumeadosTinta;
namespace eje__305
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo cuadrado = new Rectangulo(new Punto(2, 0), new Punto(4, 4));
            ImprimirRectangulo(cuadrado);
        }

        public static void ImprimirRectangulo(Rectangulo rectanguloInstanciado)
        {
            Console.WriteLine("Perimetro:{0} \nArea:{1}", rectanguloInstanciado.Perimetro(), rectanguloInstanciado.Area());
        }
    }
}
