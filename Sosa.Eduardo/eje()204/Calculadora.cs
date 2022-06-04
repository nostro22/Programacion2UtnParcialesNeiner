using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje__204
{
    class Calculadora
    {
    public static float Calcular(float primerOperando, float segundoOperando, string operacionMatematica)
        {
            float respuesta = 0;
            switch (operacionMatematica)
            {
                case "+":
                    respuesta = primerOperando + segundoOperando;
                    break;
                case "-":
                    respuesta = primerOperando - segundoOperando;
                    break;
                case "*":
                    respuesta = primerOperando * segundoOperando;
                    break;
                case "/":
                    if(Calculadora.Validar(segundoOperando))
                    {
                        respuesta = primerOperando / segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    break;                    
            }
            return respuesta;
        }

        private static bool Validar(float segundoOperando)
        {
            if (segundoOperando != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
    

}
