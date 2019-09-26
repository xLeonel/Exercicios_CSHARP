using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] temperatura = new double[12];

            for (int i = 0; i < 12; i++)
            {
                Console.Write("Digite " + (i + 1) + "º temperatura: ");
                temperatura[i] = double.Parse(Console.ReadLine());
            }

            double maior = temperatura[0];
            double menor = temperatura[0];


            foreach (double temp in temperatura)
            {


                if (temp > maior)
                {
                    maior = temp;

                }
                else if (temp < menor)
                {
                    menor = temp;

                }
            }

            Console.WriteLine($"O maior numero é  {maior}");
            Console.WriteLine($"O menor numero é  {menor}");
        }
    }
}
