using System;

namespace CSharpOO_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius() { Temperature = 30 };
            Fahrenheit fahrenheit = celsius; //use implicit cast operator
            celsius = (Celsius)fahrenheit; //use explicit cast operator

            Console.WriteLine($"{celsius.Temperature} °C");
            Console.WriteLine($"{fahrenheit.Temperature} °F");
        }
    }
}
