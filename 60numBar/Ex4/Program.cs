using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                System.Console.WriteLine($"{numero} é par");
            }
            else
            {
                System.Console.WriteLine($"{numero} é ímpar");
            }
        }
    }
}
