using System;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            do {
                Console.Write("Digite um número ou zero para parar: ");
                num = int.Parse(Console.ReadLine());

                if ((num % 2) !=0) {
                    Console.WriteLine("O número é impar.");
                } else {
                    Console.WriteLine("O número é par.");
                }

            }while (num != 0);
                 
            
        }
    }
}
