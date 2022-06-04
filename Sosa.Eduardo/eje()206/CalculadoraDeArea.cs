using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje__206
{
    class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return longitudLado * longitudLado;
        }
        public static double CalcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            return (baseTriangulo * altura / 2);
        }
        public static double CalcularAreaCirculo(double radio) 
        {            
            return (MathF.Pow((float)radio,2)*MathF.PI);
        }
    }
}
