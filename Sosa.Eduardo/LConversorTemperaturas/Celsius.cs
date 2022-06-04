using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LConversorTemperaturas
{
    class Celsius
    {
        private double temperatura;

        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public Kelvin ToKelvin()
        {
            return new Kelvin(this.temperatura + 273.15);
        }
        public Fahrenheit ToFahrenheit()
        {
            return new Fahrenheit(this.temperatura*1.8 + 32);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return c.ToKelvin();
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return c.ToFahrenheit();
        }


    }


}
