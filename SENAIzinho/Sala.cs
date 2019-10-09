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

        public void AlocarAluno (string[] Alunos)
        {
            if ( capacidadeAtual < capacidadeTotal)
            {
                capacidadeAtual = capacidadeAtual -1;
                Alunos[capacidadeTotal - capacidadeAtual] = Alunos[0];
            }
            else 
            {
                System.Console.WriteLine("Sala Cheia.");
            }
        }

    }
}