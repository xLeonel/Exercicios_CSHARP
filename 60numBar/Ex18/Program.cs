using System;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira um limite para o intervalo: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                if ((i % 2) != 0)
                {
                    System.Console.Write($"{i} ");
                }
            }
        }
    }
}
