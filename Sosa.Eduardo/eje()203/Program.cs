using System;

namespace eje__203
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario="";
            int entero = 0;
            binario =Conversor.ConvertirDecimalABinario(695);
            Console.WriteLine(binario);
            entero = Conversor.ConvertirBinarioADecimal(1010110111);
            Console.WriteLine(entero);
        }
    }
}
