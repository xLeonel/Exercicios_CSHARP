using System;

namespace todas_tabuadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione Enter para imprimir as tabuadas.");
            Console.ReadLine();

            
            for (int num=1; num<=10; num+=1) {

                for (int num2=1; num2 <=10; num2+=1)
                {
                    Console.Write($"{num,-2} * {num2,-2} = {num2*num,-3} ");
                }

                Console.WriteLine("Tabuada do " + num);
                
            }
        }
    }
}
