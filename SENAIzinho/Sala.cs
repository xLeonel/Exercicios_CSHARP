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
            this.capacidadeAtual = this.capacidadeTotal;
            this.Alunos = new string[capacidadeTotal];
        }

        public string AlocarAluno(string nomeAluno)
        {
            int index = 0;
            if (this.capacidadeAtual > 0)
            {
                foreach (string item in this.Alunos)
                {
                    if (item != "") // cheio
                    {
                        index++;
                    }
                    else
                    {
                        this.Alunos[index] = nomeAluno;
                    }
                }
                this.capacidadeAtual--;
                return "Cadastro com Sucesso";
            }
            else
            {
                return "Sala cheia";
            }
        }

        public string RemoverAluno(string nomeAluno)
        {
            int index = 0;

            if (this.capacidadeAtual == this.capacidadeTotal)
            {
                return "Sala vazia";
            }

            foreach (string item in this.Alunos)
            {
                if (nomeAluno == item)
                {
                    this.Alunos[index] = "";
                    return "Aluno removido.";
                }
                index++;
            }
            return "Aluno não encontrado.";
        }

        public string MostrarAluno()
        {
            string listaAlunos = "";
            foreach (string aluno in this.Alunos)
            {
                if (aluno != "")
                {
                    listaAlunos = aluno;
                }
            }
            // listaAlunos.TrimEnd();
            return listaAlunos;
        }
    }
}