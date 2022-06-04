using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje__clase2
{
    class Sello
    {
        public static  string mensaje;
        public static ConsoleColor color = ConsoleColor.Red;

        public static string Imprimir()
        {
            string mensajeConFormato;
            if(Sello.TryParse(mensaje,out mensajeConFormato))
            {
                return mensajeConFormato;
            }
            else
            {
                return mensaje;
            }
            
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje()
        {
            string mensajeEnFormato="";
            int cantidadDeAsteriscos = Sello.mensaje.Length;
            for (int i = 0; i < cantidadDeAsteriscos+2; i++)
            {
                mensajeEnFormato = mensajeEnFormato + "*";
            }
            mensajeEnFormato = mensajeEnFormato + "\n*" + mensaje + "*\n"+ mensajeEnFormato;
          
            return mensajeEnFormato;
        }

        private static bool TryParse(string mensaje,out string salida)
        {
            if(string.IsNullOrWhiteSpace(Sello.mensaje))
            {
                salida = "";
                return false;
            }
            else
            {
                salida = Sello.ArmarFormatoMensaje();
                return true;
            }
            
        }
    }
}


/*

clase Sello
(+) mensaje : string
(+) color : ConsoleColor
(+) Imprimir() : string
(+) Borrar() : void
(+) ImprimirEnColor() : void
(-) ArmarFormatoMensaje : string
(-) TryParse(string, out string) : bool

*/