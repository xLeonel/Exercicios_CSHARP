using System;

namespace Ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Qual o tamanho do seu Vetor A? ");
            int tamanhoA = int.Parse(Console.ReadLine());
            System.Console.Write("Qual o tamanho do seu Vetor B? ");
            int tamanhoB = int.Parse(Console.ReadLine());


            int[] vetorA = new int[tamanhoA];
            int[] vetorB = new int[tamanhoB];
            int[] vetorC = new int[tamanhoA + tamanhoB];

            Random numRandom = new Random();

            for (int i = 0; i < tamanhoA; i++)
            {
                vetorA[i] = numRandom.Next(0, 10);
            }
            for (int i = 0; i < tamanhoB; i++)
            {
                vetorB[i] = numRandom.Next(0, 10);
            }
            for (int i = 0; i < tamanhoA + tamanhoB; i++)
            {
                foreach (int item in vetorA)
                {
                    foreach (int item2 in vetorB)
                    {
                        vetorC[i] = (item) + (item2);
                    }
                }
            }
            System.Console.Write("Vetor A: ");
            foreach (int item in vetorA)
            {
                System.Console.Write($"{item} ");
            }
            System.Console.WriteLine();
            System.Console.Write("Vetor B: ");
            foreach (int item in vetorB)
            {
                System.Console.Write($"{item} ");
            }
            System.Console.WriteLine();
            System.Console.Write("Vetor C: ");
            foreach (int item in vetorA)
            {
                foreach (int item2 in vetorB)
                {
                    System.Console.WriteLine($"Vetor C: {item} {item2}");
                }
            }
        }
    }
}
