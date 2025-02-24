namespace StaticExercise;
using System;

public static class TempConverter
{
    public static double FahrenheitToCelsius(double fahrenheit) // method to convert
    {
        return (fahrenheit - 32) * 5 / 9; 
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}