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

                Console.WriteLine("Tabuada do " + num );

                for (int num2=1; num2 <=10; num2+=1)
                {
                    Console.WriteLine($"{num} * {num2} = {num2*num}");
                }
                
            }
        }
    }
}
