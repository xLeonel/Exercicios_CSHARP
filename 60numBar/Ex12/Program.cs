using System;
using System.Collections.Generic;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o 1° número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o 2° número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o 3° número: ");
            int num3 = int.Parse(Console.ReadLine());

            List<int> lista = new List<int>();
            lista.Add(num1);
            lista.Add(num2);
            lista.Add(num3);
            lista.Sort();

            foreach (int item in lista)
                Console.WriteLine(item);
        }
    }
}
