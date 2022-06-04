using System;


/*
Ejercicio I01 - Máximo, mínimo y promedio
Consigna#
Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
 * */

namespace eje__1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Console.WriteLine("\n\n Hello World!");
            String nombre =Console.ReadLine();
            String apellido = "sosa";
            int edad = 31;
            Console.WriteLine("tu nombres es " + nombre + "\n edad: "+ edad);
            Console.WriteLine("tu nombres es {0} y apellido {1}. \n Bienvenido sr.{1} ",nombre,apellido);
            Console.ReadKey();
            Console.Clear();*/
            Console.Title = "Ejercicio I01 - Máximo, mínimo y promedio";
            //variables

            float[] numeros = new float[5];
            float max;
            float min;
            float average;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = ingresarNumero();
            }
            max = numeros[0];
            min = numeros[0];
       
            Console.Clear();
            average = getAverage(numeros);
            max = getMax(numeros);
            min = getMin(numeros);
            Console.WriteLine("Max: {0} \nMin: {1} \nAverage: {2} ", max,min,average);
        }


       public static float ingresarNumero()
        {
            string ingreso;          
           
                Console.WriteLine("Ingrese un numero");
                ingreso = Console.ReadLine();
            if(float.TryParse(ingreso, out float numeroIngresado))
            {
                return numeroIngresado;
            }
            else
            {
                Console.WriteLine("Ingreso incorrecto profavor ingrese un numero");
              return ingresarNumero();
            }
        }

        public static float getMax(float[] ingreso)
        {
            float max = ingreso[0];
            foreach (float number in ingreso)
            {
                if(number>max)
                {
                    max = number;
                }
            }

            return max;
        }

        public static float getMin(float[] ingreso)
        {
            float min = ingreso[0];
            foreach (float number in ingreso)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }

        public static float getAverage(float[] ingreso)
        {
            float average=0;
            foreach (float number in ingreso)
            {
                average += number;
            }
            average = average / ingreso.Length;
            return average;
        }
    }


}
