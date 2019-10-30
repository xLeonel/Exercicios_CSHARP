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
                Console.Clear();
                System.Console.WriteLine("Agenda Telefonica");
                System.Console.WriteLine();
                System.Console.WriteLine(" 1 - Cadastrar agenda");
                System.Console.WriteLine(" 2 - Atualizar dados");
                System.Console.WriteLine(" 3 - Remover agenda");
                System.Console.WriteLine(" 4 - Procurar agenda");
                System.Console.WriteLine(" 5 - Listar todas agendas");
                System.Console.WriteLine(" 0 - Sair");
                System.Console.WriteLine();
                int opçaoUser = int.Parse(Console.ReadLine());

                switch (opçaoUser)
                {
                    case 1:
                        Console.Clear();
                        Cadastrar(ref allAgendas);
                        break;
                    case 2:
                        Console.Clear();
                        Atualizar(ref allAgendas);
                        break;
                    case 3:
                        Console.Clear();
                        Remover(ref allAgendas);
                        break;
                    case 4:
                        Console.Clear();
                        Procurar(allAgendas);
                        break;
                    case 5:
                        Console.Clear();
                        ListarAgendas(allAgendas);
                        Console.ReadLine();
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

            bool cadastroDisponivel = true;
            foreach (var item in allAgendas)
            {
                if (nome == item.Nome)
                {
                    cadastroDisponivel = false;
                }
            }
            if (cadastroDisponivel)
            {
                AgendaTelefonica agenda = new AgendaTelefonica(nome, telefone, aniversario);
                allAgendas.Add(agenda);
                System.Console.WriteLine("Cadastrado");
                Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine("O nome já existe");
                Console.ReadLine();
            }


        }

        public static void Atualizar(ref List<AgendaTelefonica> allAgendas)
        {
            ListarAgendas(allAgendas);
            System.Console.WriteLine();
            System.Console.Write("Digite o ID que você queira atualizar: ");
            int id = int.Parse(Console.ReadLine());
            id -= 1;
            AgendaTelefonica pegarId = allAgendas[id];
            Console.Clear();
            System.Console.WriteLine($"Nome: {pegarId.Nome} | Telefone: {pegarId.Telefone} | Aniversário: {pegarId.Aniversario} ");
            System.Console.WriteLine();
            System.Console.WriteLine("Atualizar Dados");

            string nomeNovo = pegarId.Nome;
            string telefoneNovo = pegarId.Telefone; ;
            string aniversarioNovo = pegarId.Aniversario; ;

            System.Console.Write("Nome: ");
            nomeNovo = Console.ReadLine();
            if (nomeNovo == "")
            {
                nomeNovo = pegarId.Nome;
            }
            else
            {
                pegarId.Nome = nomeNovo;
                System.Console.WriteLine("Atualizado");
            }

            System.Console.Write("Telefone: ");
            telefoneNovo = Console.ReadLine();
            if (telefoneNovo == "")
            {
                telefoneNovo = pegarId.Telefone;
            }
            else
            {
                pegarId.Telefone = telefoneNovo;
                System.Console.WriteLine("Atualizado");
            }

            System.Console.Write("Aniversário: ");
            aniversarioNovo = Console.ReadLine();
            if (aniversarioNovo == "")
            {
                aniversarioNovo = pegarId.Aniversario;
            }
            else
            {
                pegarId.Aniversario = aniversarioNovo;
                System.Console.WriteLine("Atualizado");
            }
        }

        public static void Remover(ref List<AgendaTelefonica> allAgendas)
        {
            Console.Clear();
            System.Console.WriteLine("Remover Agenda");
            System.Console.WriteLine();
            ListarAgendas(allAgendas);
            System.Console.Write("Digite o ID: ");
            int id = int.Parse(Console.ReadLine());
            id -= 1;
            allAgendas.RemoveAt(id);
            System.Console.WriteLine("Removido");
            Console.ReadLine();
        }

        public static void Procurar(List<AgendaTelefonica> allAgendas)
        {
            Console.Clear();
            System.Console.WriteLine("Procurar uma Agenda");
            System.Console.WriteLine();
            System.Console.Write("Digite um Nome: ");
            string nome = Console.ReadLine();

            bool antiBug = false;
            string telefone = "";
            string aniversário = "";


            foreach (var item in allAgendas)
            {
                if (nome == item.Nome)
                {
                    nome = item.Nome;
                    telefone = item.Telefone;
                    aniversário = item.Aniversario;
                    antiBug = true;
                    break;
                }
            }
            if (antiBug)
            {
                System.Console.WriteLine($"Nome: {nome} | Telefone: {telefone} | Aniversário: {aniversário}");
            }
            else
            {
                System.Console.WriteLine("Agenda não encontrada");
            }
            Console.ReadLine();
        }

        public static void ListarAgendas(List<AgendaTelefonica> allAgendas)
        {
            Console.Clear();
            if (allAgendas.Count != 0)
            {
                int count = 1;
                foreach (var item in allAgendas)
                {
                    System.Console.WriteLine($"ID {count} // Nome: {item.Nome} | Telefone: {item.Telefone} | Aniversário: {item.Aniversario} ");
                    count++;
                }
            }
            else
            {
                System.Console.WriteLine("Ninguem foi cadastrado!");
                Console.ReadLine();
                Cadastrar(ref allAgendas);
            }

        }
    }
}
