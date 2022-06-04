using System;

namespace eje__206
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingresoFigura = 0;

            Console.WriteLine("Bienvenido selecione la figura de la cual desea calcular el area:");            
            double ingresoDouble = 0;
            double area = 0;
            
            if(Validador.IngresarNumeroEnteroPositivo(ref ingresoFigura, "1)Cuadrado\n2)Triangulo\n3)Circulo"))
            {
                switch (ingresoFigura)
                {
                    case 1:
                        Validador.IngresarNumeroDouble(ref ingresoDouble, "Ingrese la longitud del lado del cuadrado", 1, 999);
                        area = CalculadoraDeArea.CalcularAreaCuadrado(ingresoDouble);
                        Console.WriteLine("Calculando el area de tu Cuadrado...");
                        break;
                    case 2:
                        double altura = 0;
                        Validador.IngresarNumeroDouble(ref altura, "Ingrese la altura del Triangulo", 1, 999);
                        Validador.IngresarNumeroDouble(ref ingresoDouble, "Ingrese la base del Triangulo", 1, 999);
                        area = CalculadoraDeArea.CalcularAreaTriangulo(ingresoDouble,altura);
                        Console.WriteLine("Calculando el area de tu Triangulo...");
                        break;
                    case 3:
                        Validador.IngresarNumeroDouble(ref ingresoDouble, "Ingrese el radio del Circulo", 1, 999);
                        area = CalculadoraDeArea.CalcularAreaCirculo(ingresoDouble);
                        Console.WriteLine("Calculando el area de tu Circulo...");
                        break;
                }


                Console.WriteLine("Area:{0}", area);
            }

        }
    }
}
