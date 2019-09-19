using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            //variaveis//

            double num1;
            double num2;
            string oper;

            //fim varaiveis//

            Console.WriteLine("Digite o 1º número:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador:");
            oper = Console.ReadLine();

            switch(oper) {
                case "+": 
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;

                case "-": 
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;

                case "*": 
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;

                case "/": 
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;

                case "%": 
                Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                break;

                default:  
                Console.WriteLine("Operção Inválida!");
                Console.WriteLine("Use: + , - , * , / ou %");
                break;
            }
        }
    }
}
