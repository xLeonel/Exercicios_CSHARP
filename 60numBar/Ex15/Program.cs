using System;
using System.Collections.Generic;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("digite um número (entre 1 e 12): ");
            int num = int.Parse(Console.ReadLine());
            
            switch (num)
            {
                case 1:
                    Console.Clear();
                    System.Console.WriteLine("1 corresponde ao mês de Janeiro.");
                    break;
                case 2:
                    Console.Clear();
                    System.Console.WriteLine("2 corresponde ao mês de Fevereiro.");
                    break;
                case 3:
                    Console.Clear();
                    System.Console.WriteLine("3 corresponde ao mês de Março.");
                    break;
                case 4:
                    Console.Clear();
                    System.Console.WriteLine("4 corresponde ao mês de Abril.");
                    break;
                case 5:
                    Console.Clear();
                    System.Console.WriteLine("5 corresponde ao mês de Maio.");
                    break;
                case 6:
                    Console.Clear();
                    System.Console.WriteLine("6 corresponde ao mês de Junho.");
                    break;
                case 7:
                    Console.Clear();
                    System.Console.WriteLine("7 corresponde ao mês de Julho.");
                    break;
                case 8:
                    Console.Clear();
                    System.Console.WriteLine("8 corresponde ao mês de Agosto.");
                    break;
                case 9:
                    Console.Clear();
                    System.Console.WriteLine("9 corresponde ao mês de Setembro.");
                    break;
                case 10:
                    Console.Clear();
                    System.Console.WriteLine("10 corresponde ao mês de Outubro.");
                    break;
                case 11:
                    Console.Clear();
                    System.Console.WriteLine("11 corresponde ao mês de Novembro.");
                    break;
                case 12:
                    Console.Clear();
                    System.Console.WriteLine("12 corresponde ao mês de Dezembro.");
                    break;
                default:
                    System.Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
