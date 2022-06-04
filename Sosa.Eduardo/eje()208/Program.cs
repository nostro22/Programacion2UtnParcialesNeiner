using System;

namespace eje__208
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate;
            DateTime dateNow = DateTime.Now;
            TimeSpan diasVividos;
            string ingresoString ="";
            bool isRealDate = true;

            Console.WriteLine("Introduzca su fecha de nacimiento ejemplo: 22/02/1990 ");
            ingresoString = Console.ReadLine();
            isRealDate = DateTime.TryParse(ingresoString, out birthDate);
             
            if(isRealDate)
            {
                diasVividos = (dateNow.Date - birthDate.Date);
                Console.WriteLine("Cantidad de dias vividos:{0}",diasVividos.TotalDays);                
            }
            else
            {
                Console.WriteLine("Introduzca una fecha valida");
            }


            

        }
    }
}
