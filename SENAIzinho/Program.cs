using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteAlunos = 10;
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
                        Console.Clear();
                        System.Console.WriteLine();
                        CadastrarAluno(alunos,totalAlunos,alunosCadastrados);
                        break;
                    case "2":
                        Console.Clear();
                        System.Console.WriteLine("Cadastrar Sala");
                        System.Console.WriteLine();
                        CadastrarSala();
                        break;
                    case "3":
                        Console.Clear();
                        System.Console.WriteLine("Alocar Aluno");
                        System.Console.WriteLine();
                        AlocarAluno();
                        break;
                    case "4":
                        Console.Clear();
                        System.Console.WriteLine("Remover Aluno");
                        System.Console.WriteLine();
                        RemoverAluno();
                        break;
                    case "5":
                        Console.Clear();
                        System.Console.WriteLine("Verificar Salas");
                        System.Console.WriteLine();
                        VerificarSalas();
                        break;
                    case "6":
                        Console.Clear();
                        System.Console.WriteLine("Verificar Alunos");
                        System.Console.WriteLine();
                        VerificarAlunos();
                        break;
                    case "0":
                        System.Console.WriteLine("Ate a próxima!");
                        System.Console.WriteLine();
                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida.");
                        break;
                }

            } while (querSair);
            #endregion
        }

        public static void CadastrarAluno(Aluno[] alunos, int totalAlunos, int alunosCadastrados)
        {
            if (alunosCadastrados < totalAlunos)
            {
                System.Console.WriteLine("Cadastro de Aluno");
                System.Console.WriteLine();
                System.Console.Write("Nome: ");
                string nomeAluno = Console.ReadLine();
                System.Console.Write("Data de nascimento: ");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

                Aluno novoAluno = new Aluno();
                novoAluno.Nome = nomeAluno;
                novoAluno.DataNascimento = dataNascimento;

                int index = 0;
                foreach (Aluno aluno in alunos)
                {
                    if (aluno == null)
                    {
                        alunos[index] = novoAluno;
                        break;
                    }
                    index++;
                }
                alunosCadastrados++;
            }
        }

        public static void CadastrarSala()
        {
            Sala[] salasEscola = new Sala[10];
            System.Console.WriteLine("Digite o número da Sala: ");
            int numeroSala = int.Parse(Console.ReadLine());


            Sala sala1 = new Sala(numeroSala, 10);
            

            salasEscola[0] = sala1;
            System.Console.WriteLine("Sala Cadastrada");
        }

        public static void AlocarAluno()
        {
            System.Console.WriteLine("Digite o nome do Aluno: ");
            string nomeAluno = Console.ReadLine();
            System.Console.WriteLine("Digite a sala que o aluno esta: ");
            int numeroSala = int.Parse(Console.ReadLine());

        }

        public static void RemoverAluno()
        {
            System.Console.WriteLine("Digite o nome do Aluno: ");
            string nomeAluno = Console.ReadLine();

        }

        public static void VerificarSalas()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Sala {i + 1}");
                for (int k = 0; k < 10; i++)
                {
                    System.Console.WriteLine($"Aluno: ");
                }
            }
        }

        public static void VerificarAlunos()
        {

        }


    }

}
