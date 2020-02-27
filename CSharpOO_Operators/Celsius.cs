﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO_Operators
{
    class Celsius
    {
        public static implicit operator Fahrenheit(Celsius celsius)
        {
            return new Fahrenheit() { Temperature = (celsius.Temperature * 1.8) + 32 };
        }

        public double Temperature { get; set; }
    }
}
