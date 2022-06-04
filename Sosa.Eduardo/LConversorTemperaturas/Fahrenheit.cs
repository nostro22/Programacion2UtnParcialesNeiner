using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LConversorTemperaturas
{
    class Fahrenheit
    {
        private double temperatura;

        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public Kelvin ToKelvin()
        {
            return new Kelvin((5/9)*(this.temperatura-32)+273.15);
        }
        public Celsius ToCelsius()
        {
            return new Celsius((this.temperatura-32)/18);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return f.ToKelvin();
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return f.ToCelsius();
        }
    }
}
