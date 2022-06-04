using System;

namespace eje__303
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante eduardo = new Estudiante("Eduardo","Sosa","95768450");
            Estudiante andres = new Estudiante("Andres", "Sopa", "11111");
            Estudiante julio = new Estudiante("Julio", "Pala", "222222");
            eduardo.SetNotaPrimerParcial(6);
            eduardo.SetNotaSegundoParcial(8);
            andres.SetNotaPrimerParcial(5);
            andres.SetNotaSegundoParcial(10);
            julio.SetNotaPrimerParcial(2);
            julio.SetNotaSegundoParcial(4);
            
            Console.WriteLine("{0}\n{1}\n{2}",eduardo.Mostrar(), andres.Mostrar(), julio.Mostrar());

        }
    }
}
