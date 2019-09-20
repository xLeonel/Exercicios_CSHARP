using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione Enter para imprimir a tabuada do 5.");
            Console.ReadLine();

            for (int num=0; num <=50; num+=5) 
            {
                Console.Write(num + " ");
            }     
        }
    }
}
