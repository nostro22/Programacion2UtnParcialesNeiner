using System;

namespace TP1Prototipo
{
    class Program
    {
        static void Main(string[] args)
        {
            Operando n1 = new Operando(0);
            Operando n2 = new Operando("-0011000111,2521");
            double numero1 = n1.GetNumero();
            double numero2 = n2.GetNumero();
            Console.WriteLine("n1={0}\nn2={1}",numero1,numero2);
            double resultado;
            resultado = Calculadora.Operar(n1, n2, '+');
            Console.WriteLine(resultado);
            Console.WriteLine(Operando.BinarioADecimal(resultado));
        }
    }
}
