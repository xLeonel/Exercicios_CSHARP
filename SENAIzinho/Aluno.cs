using System;

namespace SENAIzinho
{
    public class Aluno
    {
        public string Nome;
        public DateTime DataNascimento;
        public string Curso;
        public int numeroSala;

        public Aluno(string Nome)
        {
            this.Nome = Nome;
        }
    }

}