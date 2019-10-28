using System;

namespace Ex28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Cadastrar Agenda");
            System.Console.WriteLine();
            System.Console.Write("Digite seu Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Digite seu Telefone: ");
            string telefone = Console.ReadLine();
            System.Console.Write("Digite sua Data de Nascimento: ");
            string aniversario = Console.ReadLine();

            AgendaTelefonica agenda = new AgendaTelefonica(nome, telefone, aniversario);
            System.Console.WriteLine("Cadastrado");
            Console.ReadLine();

            bool logou = false;
            do
            {
                Console.Clear();
                System.Console.WriteLine("Entrar na sua Agenda");
                System.Console.Write("Digite seu Nome: ");
                nome = Console.ReadLine();
                System.Console.Write("Digite sua Data de Nascimento: ");
                aniversario = Console.ReadLine();
                if ((nome == agenda.Nome) && (aniversario == agenda.Aniversario))
                {
                    Console.Clear();
                    logou = true;
                    System.Console.WriteLine("Bem Vindo a sua Conta");
                    System.Console.WriteLine();
                    System.Console.WriteLine($"Nome: {agenda.Nome}\nTelefone: {agenda.Telefone}\nAniversário: {agenda.Aniversario}");
                }
                else
                {
                    System.Console.WriteLine("Credenciais incorretas");
                    Console.ReadLine();
                }

            } while (!logou);
        }
    }
}
