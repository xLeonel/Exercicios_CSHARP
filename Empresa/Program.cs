using System;

namespace Empresa
{
    class Program
    {
        public static void Main(string[] args)
        {
            double reajuste = 30.0/100.0;
            double salario;
            
            Console.WriteLine("Qual é seu salário?");
            salario = double.Parse(Console.ReadLine());

            if (salario < 500.0){
                salario = salario + ( salario * reajuste );
                Console.WriteLine("Parabéns, você tem um reajuste disponível!");
                Console.WriteLine("Saldo atual: " + salario);
            } else {
                Console.WriteLine("Ops, infelizmente você não tem reajuste.");
            }
        }
    }
}
