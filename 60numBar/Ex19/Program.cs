using System;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Quantas posições você deseja ? ");
            int positionVetor = int.Parse(Console.ReadLine());

            int[] numInteiros = new int[positionVetor];

            Console.Clear();
            System.Console.WriteLine($"Digite {positionVetor} números para ser alocado no vetor: ");

            for (int i = 0; i < positionVetor; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numInteiros[i] = num;
            }
            Console.Clear();
            
            foreach (int item in numInteiros)
            {
                System.Console.Write($"{item} ");
            }
        }
    }
}
