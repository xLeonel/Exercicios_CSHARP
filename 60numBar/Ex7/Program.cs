using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Números Ímpares: ");
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    System.Console.Write($"{i} ");
                }
            }
        }
    }
}
