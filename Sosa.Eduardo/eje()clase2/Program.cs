using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje__clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje ="hola mundo";
            Console.WriteLine(Sello.Imprimir());
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());            
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
        }
    }
}


/*
 * clase Sello
(+) mensaje : string
    
(+) Imprimir() : string ---> return Sello.mensaje;
(+) Borrar() : void -----> Sello.mensaje = "";
Main()
Sello.mensaje = "hola mundo"
Sello.Imprimir();//retorna string
Sello.Borrar();
Sello.Imprimir();//retorna string
*/






