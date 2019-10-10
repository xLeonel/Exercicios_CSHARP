using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            bool querSair = true;
            //*Var */

            System.Console.WriteLine("==============================");
            System.Console.WriteLine("         SENAIzinho");
            System.Console.WriteLine("==============================");
            System.Console.WriteLine();

            //* MENU */

            do
            {

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
                        System.Console.WriteLine("Cadastrar Aluno");
                        System.Console.WriteLine();
                        CadastrarAluno();
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
                        System.Console.WriteLine("Tchau!");
                        querSair = false;
                        System.Console.WriteLine();
                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida.");
                        break;
                }

            } while (querSair);
        }

        public static void CadastrarAluno()
        {
            int limiteAlunos = 100;
            int alunosCadastrados = 0;

            if (alunosCadastrados < limiteAlunos)
            {
                System.Console.Write("Digite o nome do Aluno: ");
                string nomeAluno = Console.ReadLine();
                System.Console.Write("Digite a idade do Aluno: ");
                int idadeAluno = int.Parse(Console.ReadLine());
                Aluno aluno1 = new Aluno(nomeAluno, idadeAluno);
                Sala sala1 = new Sala(1,10);
                sala1.AlocarAluno(nomeAluno);
                
            }
            else 
            {
                
            }

            System.Console.WriteLine();
        }

        public static void CadastrarSala()
        {
            int limiteSalas = 10;
            int salasCadastradas = 0;

            Sala[] salas = new Sala[10];
            System.Console.Write("Digite o número da Sala: ");
            int numeroSala = int.Parse(Console.ReadLine());

            Sala sala1 = new Sala(numeroSala, 10);

            salasCadastradas +=1;
            if ( salasCadastradas <= limiteSalas)
            {
            System.Console.WriteLine("Sala Cadastrada");
            } 
            else 
            {
                System.Console.WriteLine("Nao pode criar mais salas.");
            }
            System.Console.WriteLine();

        }

        public static void AlocarAluno()
        {
            System.Console.Write("Digite o nome do Aluno: ");
            string nomeAluno = Console.ReadLine();
            System.Console.Write("Digite a sala que o aluno esta: ");
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
            }
        }

        public static void VerificarAlunos()
        {
        
        }


    }

}
