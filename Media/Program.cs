using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1,nota2,nota3,nota4, media;


            Console.Write("Digite sua Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua Nota 3: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua Nota 4: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4 ; 

            Console.WriteLine("Sua média é: " + media);

            if(media >= 7) {
                Console.WriteLine("Você está Aprovado");
            } else {
                Console.WriteLine("Você está Reprovado");
            }

        }
    }
}
