using System;
using byteBankTest.Models;

namespace byteBankTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente1 = new ContaCorrente(1,1,"unknown");
            ContaCorrente contaCorrente2 = new ContaCorrente(2,2,"unknown2");

            ContaEspecial contaEspecial = new ContaEspecial(3,3,"unknownSpecial");
        }

        public static void DepositarConta ( ContaBancaria contaBancaria)
        {
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            Cliente usuario = ContaBancaria.Titular;
            System.Console.WriteLine($"Bem-Vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            double valor = 0.0;
            do
            {
                System.Console.Write("Digite o valor do Depósito: ");
                valor = double.Parse(Console.ReadLine());
                if (valor >= 0)
                {
                    contaCorrente1.deposito(valor);
                }
                else
                {
                    System.Console.WriteLine("Valor tem que ser positivo.");
                }
            } while (valor < 0);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
        }
    }
}
