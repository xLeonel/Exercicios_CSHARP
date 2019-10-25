using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite a altura do seu triângulo: ");
            int alturaTriangulo = int.Parse(Console.ReadLine());

            for (int i = alturaTriangulo; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }
        }
    }
}
