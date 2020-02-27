using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO_Operators
{
    class Fahrenheit
    {
        public static implicit operator Celsius(Fahrenheit fahrenheit)
        {
            return new Celsius() { Temperature = (fahrenheit.Temperature - 32) / 1.8 };
        }

        public double Temperature { get; set; }
    }
}
