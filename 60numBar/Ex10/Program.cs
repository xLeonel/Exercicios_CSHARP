using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Escreva um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 3 == 0)
            {
                System.Console.WriteLine($"O {numero} é múltiplo de 3.");
            }
            System.Console.WriteLine("Não é múltiplo de 3.");
        }
    }
}
