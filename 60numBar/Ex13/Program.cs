using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a base do seu Triangulo: ");
            int baseTriangulo = int.Parse(Console.ReadLine());
            Console.Write("Digite o lado 1 do seu Triangulo: ");
            int lado1Triangulo = int.Parse(Console.ReadLine());
            Console.Write("Digite a lado 2 do seu Triangulo: ");
            int lado2Triangulo = int.Parse(Console.ReadLine());

            if ((baseTriangulo) < (lado1Triangulo + lado2Triangulo))
            {
                System.Console.WriteLine("Triangulo válido");
            }
            else
            {
                System.Console.WriteLine("Triangulo não é válido");
            }
        }
    }
}
