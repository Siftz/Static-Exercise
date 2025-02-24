using System;
namespace StaticExercise
{
    class Program
    {
        static void Main()
        {
            //testing converter
            //F to C
            double fahrenheit = 98.6;
            double Celsius = TempConverter.FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit}\u00b0F is equal to {Celsius:F2}\u00b0C"); // "°" is provided from the \u00b0
            
            // C to F
            double celsius2 = 37.0;
            double fahrenheit2 = TempConverter.CelsiusToFahrenheit(Celsius);
            Console.WriteLine($"{celsius2}°C is equal to {fahrenheit2:F2}°F");
            
        }
    }
}
