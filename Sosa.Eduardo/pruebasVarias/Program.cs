using System;
using System.Text;

namespace pruebasVarias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StringBuilder sb = new StringBuilder();
            string str = "marca - pais";
            string[] marca = str.Split(new[] { '-' });

            Console.WriteLine(marca[0]);
        }
    }
}
