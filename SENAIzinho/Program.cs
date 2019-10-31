using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteSalas = 10;
            int totalAlunos = 100;
            Aluno[] alunos = new Aluno[100];
            Sala[] salas = new Sala[10];
            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            bool querSair = false;


            #region MENUZAO 
            do
            {
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("         SENAIzinho");
                System.Console.WriteLine("==============================");
                System.Console.WriteLine();
                System.Console.WriteLine("1 - Cadastrar Aluno");
                System.Console.WriteLine("2 - Cadastrar Sala");
                System.Console.WriteLine("3 - Alocar Aluno");
                System.Console.WriteLine("4 - Remover Aluno");
                System.Console.WriteLine("5 - Verificar Salas");
                System.Console.WriteLine("6 - Verificar Alunos");
                System.Console.WriteLine("0 - Sair");
                string opçaoMenu = Console.ReadLine();

                switch (opçaoMenu)
                {
                    case "1":
                        CadastrarAluno(ref alunos, ref alunosCadastrados, totalAlunos);
                        break;
                    case "2":
                        CadastrarSala(ref salas, ref salasCadastradas, limiteSalas);
                        break;
                    case "3":
                        AlocarAluno(ref alunos, ref salas);
                        break;
                    case "4":
                        RemoverAluno();
                        break;
                    case "5":
                        VerificarSalas(salas);
                        break;
                    case "6":
                        VerificarAlunos(alunos);
                        break;
                    case "0":
                        System.Console.WriteLine("Ate a próxima!");
                        querSair = true;
                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida.");
                        break;
                }

            } while (!querSair);
            #endregion
        }

        public static void CadastrarAluno(ref Aluno[] alunos, ref int alunosCadastrados, int totalAlunos)
        {
            Console.Clear();
            if (alunosCadastrados < totalAlunos)
            {
                System.Console.WriteLine("Cadastro de Aluno");
                System.Console.WriteLine();
                System.Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Aluno aluno = new Aluno(nome);

                int index = 0;
                bool cadastro = false;
                foreach (var posiçao in alunos)
                {
                    if (posiçao != null) // cheio
                    {
                        index++;
                        cadastro = false;
                    }
                    else
                    {
                        cadastro = true;
                        alunos[index] = aluno;
                    }
                }
                if (cadastro)
                {
                    alunosCadastrados++;
                    System.Console.WriteLine("Cadastrado");
                    Console.ReadLine();

                }
                else
                {
                    System.Console.WriteLine("Escola cheia");
                    Console.ReadLine();
                }
            }
        }

        public static void CadastrarSala(ref Sala[] salas, ref int salasCadastradas, int limiteSalas)
        {
            Console.Clear();
            if (salasCadastradas < limiteSalas)
            {
                System.Console.WriteLine("Cadastro de Sala");
                System.Console.WriteLine();
                System.Console.Write("Digite o número da sala: ");
                int numeroSala = int.Parse(Console.ReadLine());

                Sala sala = new Sala(numeroSala, 10);
                int index = 0;
                bool cadastro = false;
                foreach (var item in salas)
                {
                    if (item != null) // cheio
                    {
                        index++;
                        cadastro = false;
                    }
                    else
                    {
                        cadastro = true;
                        salas[index] = sala;
                    }
                }
                if (cadastro)
                {
                    System.Console.WriteLine("Sala cadastrada");
                    salasCadastradas++;
                    Console.ReadLine();
                }
                else
                {
                    System.Console.WriteLine("Vetor de sala não suporta mais salas");
                    Console.ReadLine();
                }
            }
            else
            {
                System.Console.WriteLine("Escola não suporta mais salas");
                Console.ReadLine();
            }
        }

        public static void AlocarAluno(ref Aluno[] alunos, ref Sala[] salas)
        {
            Console.Clear();
            System.Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            System.Console.Write("Digite a sala: ");
            int numeroSala = int.Parse(Console.ReadLine());

            bool alunoExist = false;
            bool salaExist = false;
            foreach (var aluno in alunos)
            {
                if (nome == aluno.Nome)
                {
                    alunoExist = true;
                }
                else
                {
                    break;
                }
            }
            foreach (var item in salas)
            {
                if (numeroSala == item.numeroSala)
                {
                    salaExist = true;
                }
                else
                {
                    break;
                }
            }

            if (salaExist && alunoExist)
            {
                foreach (var item in salas)
                {
                    if (numeroSala == item.numeroSala)
                    {
                        item.AlocarAluno(nome);
                    }
                }
            }



        }

        public static void RemoverAluno()
        {
        }

        public static void VerificarSalas(Sala[] salas)
        {
            Console.Clear();
            int count = 1;
            foreach (var item in salas)
            {
                if (item != null)
                {
                    System.Console.WriteLine($"ID {count} // Sala: {item.numeroSala} ");
                    count++;
                }
            }
            Console.ReadLine();
        }

        public static void VerificarAlunos(Aluno[] alunos)
        {
            Console.Clear();
            int count = 1;
            foreach (var item in alunos)
            {
                if (item != null)
                {
                    System.Console.WriteLine($"ID {count} // Nome: {item.Nome} | Sala:  ");
                    count++;
                }
            }
            Console.ReadLine();

        }
    }
}
