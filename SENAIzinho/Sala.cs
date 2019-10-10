using System;

namespace SENAIzinho
{
    public class Sala
    {
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string[] Alunos;

        public Sala(int numeroSala, int capacidadeTotal)
        {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
        }

        public string AlocarAluno(string nomeAluno)
        {
            if ( capacidadeAtual < capacidadeTotal)
            {
                this.Alunos = new string[10];
                Alunos[0] = nomeAluno;
                System.Console.WriteLine("Cadastrado com sucesso.");
            }
            else 
            {
                System.Console.WriteLine("Sala Cheia.");
            }
            return "Alunos";
        }

        // public string RemoverAluno (string)
        // {

        // }
        
        public string MostrarAlunos() 
        {

            return Alunos[0];
        }

    }
}