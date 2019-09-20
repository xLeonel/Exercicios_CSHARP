using System;

namespace impares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione Enter para imprimir os números impar ate 100.");
            Console.ReadLine();

            for (int num=1; num <=100; num+=2) 
            {
                Console.Write(num + " ");
            }     
        }
    }
}
