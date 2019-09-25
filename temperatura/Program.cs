using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numeros = new double[12];
            double maior = 0;
            double menor = 9999999999;

            for (int i = 0; i <= 11; i++)
            {
                Console.Write("Digite " + (i + 1) + "º temperatura: ");
                numeros[i] = double.Parse(Console.ReadLine());

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    
                }
                else if (numeros[i] > maior)
                {              
                    maior = numeros[i];
     
                }

            }
            Console.WriteLine("O maior numero é " + maior);
            Console.WriteLine("O menor numero é " + menor);
        }
    }
}
