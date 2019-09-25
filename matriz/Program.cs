using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[6];
            int par = 0;
            int impar = 0;

            for (int i = 0; i <= 5; i++)
            {
                Console.Write("Digite " + (i + 1) + "º número: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    ++par;
                }
                else
                {
                    ++impar;
                }

            }
            Console.WriteLine(par + " números par");
            Console.WriteLine(impar + " números impar");
        }
    }
}
