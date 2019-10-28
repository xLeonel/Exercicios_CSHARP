using System;
using System.Collections.Generic;

namespace Ex26
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Quantos nome você deseja adicionar? ");
            int quantidade = int.Parse(Console.ReadLine());

            List <string> nomes = new List<string>();

            for (int i = 0; i < quantidade; i++)
            {
                System.Console.Write("Digite um nome: ");
                string name = Console.ReadLine();
                nomes.Add(name);
            }
            System.Console.Write("Nomes adicionados: {0}", nomes.Count);
        }
    }
}
