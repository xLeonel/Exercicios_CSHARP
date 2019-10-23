using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o valor de A: ");
            double valorA = double.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor de B: ");
            double valorB = double.Parse(Console.ReadLine());

            valorA += valorB;
            valorB = valorA - valorB;
            valorA -= valorB;

            System.Console.WriteLine();
            System.Console.WriteLine($"Valor de A: {valorA}");
            System.Console.WriteLine($"Valor de B: {valorB}");
        }
    }
}
