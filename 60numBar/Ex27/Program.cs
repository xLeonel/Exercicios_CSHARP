using System;
using System.Collections.Generic;

namespace Ex27
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = true;
            Dictionary<string, DateTime> agenda = new Dictionary<string, DateTime>();
            do
            {
                Console.Clear();
                System.Console.WriteLine("Agenda de aniversários");
                System.Console.WriteLine();
                System.Console.WriteLine(" 1 - Adicionar um aniversário");
                System.Console.WriteLine(" 2 - Remover um aniversário");
                System.Console.WriteLine(" 3 - Procurar um aniversário");
                System.Console.WriteLine(" 4 - Listar todos aniversário");
                System.Console.WriteLine(" 0 - Sair");
                int opçaoUser = int.Parse(Console.ReadLine());


                switch (opçaoUser)
                {
                    case 1:
                        Adicionar(ref agenda);
                        break;
                    case 2:
                        Remover(ref agenda);
                        break;
                    case 3:
                        Procurar(agenda);
                        break;
                    case 4:
                        ListarAgenda(agenda);
                        break;
                    case 0:
                        querSair = false;
                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida");
                        break;
                }

            } while (querSair);
        }

        public static void Adicionar(ref Dictionary<string, DateTime> agenda)
        {
            Console.Clear();
            System.Console.Write("Digite o nome da pessoa: ");
            string name = Console.ReadLine();
            System.Console.Write("Digite a data de nascimento dela: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            agenda.Add(name, data);
            System.Console.WriteLine("Pessoa adicionado");
            Console.ReadLine();
        }

        public static void Remover(ref Dictionary<string, DateTime> agenda)
        {
            Console.Clear();
            ListarAgenda(agenda);
            System.Console.Write("Digite o nome da pessoa que você queira remover: ");
            string name = Console.ReadLine();
            if (agenda.ContainsKey(name))
            {
                agenda.Remove(name);
                System.Console.WriteLine("Pessoa removida");
            }
            else
            {
                System.Console.WriteLine("Pessoa não encontrada");
            }
            Console.ReadLine();
        }

        public static void Procurar(Dictionary<string, DateTime> agenda)
        {
            Console.Clear();
            System.Console.Write("Digite o nome da pessoa que queira achar: ");
            string name = Console.ReadLine();

            if (agenda.ContainsKey(name))
            {
                System.Console.Write($"Nome: {name} {agenda[name]}");
                Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine("Nome não encontrado");
            }
        }

        public static void ListarAgenda(Dictionary<string, DateTime> agenda)
        {
            Console.Clear();
            foreach (var item in agenda)
            {
                System.Console.WriteLine($"{item}");
            }
            Console.ReadLine();
        }
    }
}
