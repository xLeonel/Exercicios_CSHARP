using System;
using System.Collections.Generic;

namespace Ex24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] vetorB = { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] vetorC = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetorC[i] = vetorA[i] + vetorB[i];
            }
            System.Console.Write("VetorA + VetorB = ");
            foreach (var item in vetorC)
            {
                System.Console.Write($"{item} ");
            } 
        }
    }
}
