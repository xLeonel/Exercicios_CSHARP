using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um verbo no infinitivo: ");
            string verbo = Console.ReadLine();

            bool oneconj = verbo.EndsWith("ar");
            bool twoconj = verbo.EndsWith("er");
            bool threeconj = verbo.EndsWith("ir");

            if (oneconj)
            {
                System.Console.WriteLine("Verbo da 1ª conjugação.");
            }
            else if (twoconj)
            {
                System.Console.WriteLine("Verbo da 2ª conjugação.");
            }
            else if (threeconj)
            {
                System.Console.WriteLine("Verbo da 3ª conjugação.");
            }
            else
            {
                System.Console.WriteLine("Verbo não está no infinitivo");
            }
        }
    }
}
