using System;

namespace dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, quantidade;

            Console.WriteLine("Qual a altura do seu Triângulo?");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos Triângulos você deseja?");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int a = 1; a <= quantidade; a++)
            {

                for (int b = 0; b <= altura; b++)
                {

                    for (int c = 1; c <= b; c++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}