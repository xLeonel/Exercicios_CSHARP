using System;

namespace faixaEtaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            int idade;

            do {

                Console.Write("Qual ano você nasceu? ");
                ano = int.Parse(Console.ReadLine());
                if (( ano > 2021 ) || (ano <0)){
                    Console.WriteLine("Ano Inválido");
                }
                idade = 2019 - ano;
            } while (( ano > 2021 ) || (ano <0) ); 

                
            if ( idade < 3 ) {
                Console.WriteLine("Você tem " + idade + " anos.");
                Console.WriteLine("Sendo assim você é um Recém-Nascido.");

            } else if ( (idade >= 3) && (idade <= 11) ) {
                Console.WriteLine("Você tem " + idade + " anos.");
                Console.WriteLine("Sendo assim você é uma Criança.");

            } else if ( (idade >= 12) && (idade <= 19) ) {
                Console.WriteLine("Você tem " + idade + " anos.");
                Console.WriteLine("Sendo assim você é um Adolescente.");

            } else if ( (idade >= 20) && (idade <= 65) ) {
                Console.WriteLine("Você tem " + idade + " anos.");
                Console.WriteLine("Sendo assim você é um Adulto.");

            } else if ( idade > 65 ) {
                Console.WriteLine("Você tem " + idade + " anos.");
                Console.WriteLine("Sendo assim você é um Idoso.");
            }
        }
    }
}
