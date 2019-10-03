using System;
using byteBank.Models;

namespace byteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("==============================");
            System.Console.WriteLine("ByteBank - Cadastro de Clientes");
            System.Console.WriteLine("==============================");

            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Cpf: ");
            string cpf = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome, cpf, email);

            bool trocouSenha = false;
            do
            {
                System.Console.Write("Senha: ");
                string senhaUsuario = Console.ReadLine();
                trocouSenha = cliente1.TrocarSenha(senhaUsuario);
                if (trocouSenha)
                {
                    System.Console.WriteLine("Senha alterada com sucesso.");
                }
                else
                {
                    System.Console.WriteLine("Senha inválida.");
                    System.Console.WriteLine("A senha precisa ter entre 6 e 16 caracteres.");
                }
            } while (!trocouSenha);

            Console.Clear();

            System.Console.Write("Agência: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            System.Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();

            ContaCorrente contaCorrente1 = new ContaCorrente(agencia, numero, titular);

            double saldoConta = 0;
            do
            {
                System.Console.Write("Saldo: ");
                saldoConta = double.Parse(Console.ReadLine());
                if (saldoConta >= 0)
                {
                    System.Console.WriteLine($"Seu saldo: {saldoConta}");
                }
                else
                {
                    System.Console.WriteLine("Saldo inválido");
                }
            } while (saldoConta < 0);

        }
    }
}
