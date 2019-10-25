using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite seu nome: ");
            string nome1 = Console.ReadLine();
            System.Console.Write("Digite outro nome: ");
            string nome2 = Console.ReadLine();
              
            if ((string.CompareOrdinal(nome1,nome2)) > 0)
            {
                System.Console.WriteLine($"{nome1}\n{nome2}");
            }
        }
    }
}
