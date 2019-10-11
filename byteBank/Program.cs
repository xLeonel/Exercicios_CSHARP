using System;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            #region Cadastro de clientes
            System.Console.WriteLine("ByteBank - Cadastro de Clientes");
            System.Console.WriteLine();
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome, cpf, email);

            bool trocousenha = false;

            do
            {
                System.Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocousenha = cliente1.TrocaSenha(senha);
                if (trocousenha)
                {
                    System.Console.WriteLine("Sua senha foi alterada com sucesso");
                }
                else
                {
                    System.Console.WriteLine("A senha precisa ter entre 6 e 16 caracteres.");
                }
            } while (!trocousenha);

            System.Console.WriteLine();

            #endregion
            Console.Clear();
            #region Cadastro da conta
            System.Console.WriteLine("ByteBank - Cadstro de Contas");
            System.Console.WriteLine();
            System.Console.Write("Entre com a agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Entre com a conta: ");
            int conta = int.Parse(Console.ReadLine());

            ContaCorrente contaCorrente1 = new ContaCorrente(agencia, conta, cliente1);
            double saldo;
            do
            {
                System.Console.Write("Entre com o saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if (saldo > 0)
                {
                    contaCorrente1.deposito(saldo);
                }
                else
                {
                    System.Console.WriteLine("Valor do saldo deve ser positivo.");
                }
            } while (saldo < 0);
            System.Console.WriteLine();
            #endregion

            Cliente cliente2 = new Cliente("cesar", "123.123.123-12", "1a@email.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123, 321, cliente2);

            #region Deposito
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            Cliente usuario = contaCorrente1.Titular;
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
            #endregion

            #region Saque
            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine($"Bem-Vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor para o Saque: ");
            valor = double.Parse(Console.ReadLine());
            if (valor > 0)
            {
                contaCorrente1.saque(valor);
            }
            else
            {
                System.Console.WriteLine("Valor tem que ser positivo.");   
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            #endregion

            #region Transferencia
            System.Console.WriteLine("ByteBank - Transferencia");
            System.Console.WriteLine($"Bem-Vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor da Transferencia: ");
            valor = double.Parse(Console.ReadLine());
            if (contaCorrente1.transferencia(contaCorrente2, valor))
            {
                System.Console.WriteLine("Transação Efetuada.");
            }
            else
            {
                System.Console.WriteLine("Não foi possivel realizar a operação.");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo Origem: {contaCorrente1.Saldo}");
            #endregion
        }
    }
}
