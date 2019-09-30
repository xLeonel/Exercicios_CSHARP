using System;

namespace Aluno
{
    public class Aluno
    {
        // atributos
        public string Nome { get; set; }
        public string Curso { get; set; }
        public string Cpf { get; set; }
        public int[] Notas;


        //contrutor
        public Aluno(string Nome, string Cpf)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            Notas = new int[4];
        }

        public Aluno(string Nome, string Cpf, string Curso)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Curso = Curso;
            Notas = new int[4];
        }

        // metodos de acesso
        public int[] getNotas() { return Notas; }

        public void setNotas(int bi, int nota)
        {
            int i = bi - 1;

            if ((i < 0) || (i > 3))
            //condiçao de erro
            {
                throw new ArgumentOutOfRangeException($"{nameof(Notas)} must be 1 and 4");
            }
            else if (nota < 0 || nota > 10)
            //condiçao de erro
            {
                throw new ArgumentOutOfRangeException($"{nameof(Notas)} mus be 1 and 04");
            }
            else
            {
                this.Notas[bi] = nota;
            }

        }
    }
}