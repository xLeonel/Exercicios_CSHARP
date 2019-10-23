using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.Write("Digite a temperatura em Centígrados: ");
            double tempCelsius = double.Parse(Console.ReadLine());

            double tempFahrenheit = (9 * tempCelsius) + 160 / 5;

            System.Console.WriteLine($"Temperatura em Fahrenheit: {tempFahrenheit}°F");
        }
    }
}
