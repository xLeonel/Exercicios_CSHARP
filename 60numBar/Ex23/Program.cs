using System;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numInteiros = new int[10];
            Random numRandom = new Random();

            for (int i = 0; i < 10; i++)
            {
                numInteiros[i] = numRandom.Next(0, 10);
            }
            System.Console.Write("Itens: ");
            foreach (int item in numInteiros)
            {
                System.Console.Write($"{item} ");
            }
            int maior = numInteiros[0];
            int menor = numInteiros[0];

            foreach (int item in numInteiros)
            {
                if (item > maior)
                {
                    maior = item;

                }
                else if (item < menor)
                {
                    menor = item;

                }
            }
            Console.WriteLine($"\nO maior numero é  {maior}");
            Console.WriteLine($"O menor numero é  {menor}");
        }
    }
}
