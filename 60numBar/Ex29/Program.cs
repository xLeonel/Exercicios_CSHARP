using System;
using System.Collections.Generic;

namespace Ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            List<AgendaTelefonica> allAgendas = new List<AgendaTelefonica>();

            do
            {
                System.Console.WriteLine("Agenda Telefonica");
                System.Console.WriteLine();
                System.Console.WriteLine(" 1 - Cadastrar agenda");
                System.Console.WriteLine(" 2 - Remover agenda");
                System.Console.WriteLine(" 3 - Procurar agenda");
                System.Console.WriteLine(" 4 - Listar todas agendas");
                System.Console.WriteLine(" 0 - Sair");
                int opçaoUser = int.Parse(Console.ReadLine());

                switch (opçaoUser)
                {
                    case 1:
                        Cadastrar(ref allAgendas);
                        break;
                    case 2:
                        Remover(ref allAgendas);
                        break;
                    case 3:
                        Procurar(allAgendas);
                        break;
                    case 4:
                        ListarAgendas(allAgendas);
                        break;
                    case 0:
                        querSair = true;
                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (!querSair);
        }

        public static void Cadastrar(ref List<AgendaTelefonica> allAgendas)
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
            allAgendas.Add(agenda);
            System.Console.WriteLine("Cadastrado");
            Console.ReadLine();
        }

        public static void Remover(ref List<AgendaTelefonica> allAgendas)
        {
            Console.Clear();
            System.Console.WriteLine("Remover Agenda");
            System.Console.WriteLine();
            System.Console.Write("Digite um Nome: ");
            string nome = Console.ReadLine();

            foreach (var item in allAgendas)
            {
                if (nome == item.Nome)
                {
                    allAgendas.Remove(item);
                    System.Console.WriteLine("Agenda removida"); 
                    break;
                }
                else
                {
                    System.Console.WriteLine("Agenda não encontrada");
                }
            }
            Console.ReadLine();
        }

        public static void Procurar(List<AgendaTelefonica> allAgendas)
        {
            Console.Clear();
            System.Console.WriteLine("Procurar uma Agenda");
            System.Console.WriteLine();
            System.Console.Write("Digite um Nome: ");
            string nome = Console.ReadLine();

            foreach (var item in allAgendas)
            {
                if (nome == item.Nome)
                {
                    System.Console.WriteLine($"Nome: {item.Nome} | Telefone: {item.Telefone} | Aniversário: {item.Aniversario}");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Agenda não encontrada");
                }
            }
            Console.ReadLine();
        }

        public static void ListarAgendas(List<AgendaTelefonica> allAgendas)
        {
            Console.Clear();
            foreach (var item in allAgendas)
            {
                System.Console.WriteLine($"Nome: {item.Nome} | Telefone: {item.Telefone} | Aniversário: {item.Aniversario} ");
            }
            Console.ReadLine();

        }
    }
}
