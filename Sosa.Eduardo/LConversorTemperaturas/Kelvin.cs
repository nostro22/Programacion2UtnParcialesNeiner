using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LConversorTemperaturas
{
    class Kelvin
    {
        private double temperatura;

        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public Celsius ToCelsius()
        {
            return new Celsius(this.temperatura - 273.15);
        }
        public Fahrenheit ToFahrenheit()
        {
            return new Fahrenheit(1.8 * (this.temperatura - 273.15) + 32);
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return k.ToCelsius(); 
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return k.ToFahrenheit();
        }

    }
}
