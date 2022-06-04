using System;
using LibraryClase3;
namespace Eje__3A01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] semanaConductor1 = { 7, 5, 2, 6, 4, 2, 0 };
            int[] semanaConductor2 = { 2, 5, 8, 1, 5, 3, 0 };
            int[] semanaConductor3 = { 1, 0, 9, 6, 3, 2, 0 };             

            Conductor conductor1 = new Conductor("Eduardo", semanaConductor1);
            Conductor conductor2 = new Conductor("Pedro", semanaConductor2);
            Conductor conductor3 = new Conductor("Marta", semanaConductor3);
            Conductor mejorConductor;
            Conductor[] listaDeConductores ={conductor1,conductor2,conductor3};
            
            mejorConductor = Conductor.CalcularMejorConductorRango(listaDeConductores, 7);           
            Console.WriteLine("El mejor Conductor en la semana es :{0}", mejorConductor.GetName());
            mejorConductor = Conductor.CalcularMejorConductorDiaEspecifico(listaDeConductores,3);
            Console.WriteLine("El mejor Conductor del dia 3 es :{0}", mejorConductor.GetName());
            mejorConductor = Conductor.CalcularMejorConductorDiaEspecifico(listaDeConductores, 5);
            Console.WriteLine("El mejor Conductor del dia 5 es :{0}", mejorConductor.GetName());
        }
    }
}
