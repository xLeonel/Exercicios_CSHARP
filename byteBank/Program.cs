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

            System.Console.Write("Digite a Agência: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o Número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o Nome do titular: ");
            string titular = Console.ReadLine();

            ContaCorrente contaCorrente1 = new ContaCorrente(agencia, conta, titular);

            double saldoConta;
            do
            {
                System.Console.Write("Digite seu saldo: ");
                saldoConta = double.Parse(Console.ReadLine());
                if (saldoConta >= 0)
                {
                    contaCorrente1.Saldo = saldoConta;
                }
                else
                {
                    System.Console.WriteLine("Saldo deve ser positivo.");
                }
            } while (saldoConta < 0);

            System.Console.Write("Valor de Depósito: ");
            double deposito = double.Parse(Console.ReadLine());

            deposito = contaCorrente1.DepositarDinheiro(deposito);


            System.Console.WriteLine($"Saldo atual: {contaCorrente1.Saldo}");


            bool saldoAtual = false;

            System.Console.Write("Valor de Saque: ");
            double saque = double.Parse(Console.ReadLine());


            saldoAtual = contaCorrente1.SacarDinheiro(saque);

            if (saldoAtual)
            {
                System.Console.WriteLine("Saque realizado com sucesso.");
                System.Console.WriteLine($"Saldo Atual: {contaCorrente1.Saldo}");
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente.");
            }

            System.Console.Write("Digite valor de transfêrencia: ");
            double transferencia = double.Parse(Console.ReadLine());

            bool transferenciaAtual = false;

            transferenciaAtual = contaCorrente1.TransferirDinheiro(transferencia);
            
            if (transferenciaAtual) 
            {
                System.Console.WriteLine("Transferencia concluida");
                System.Console.WriteLine($"Saldo Atual: {contaCorrente1.Saldo - transferencia}");
            }
            else {
                System.Console.WriteLine("Nao deu");
            }

            


        }
    }
}
