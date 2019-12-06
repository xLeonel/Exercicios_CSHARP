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
            if (this.capacidadeAtual > 0)
            {
                int index = 0;
                foreach (var item in this.Alunos)
                {
                    if (item == "")
                    {
                        this.Alunos[index] = nomeAluno;
                        break;
                    }
                    index++;
                }
                return "Alocado com sucesso";
            }
            return "Sala cheia";
        }

        public string RemoverAluno(string nomeAluno)
        {
            if (this.capacidadeAtual != 0)
            {
<<<<<<< HEAD
                int index = 0;
                foreach (var item in this.Alunos)
=======
                return "Sala vazia";
            }

            foreach (string item in this.Alunos)
            {
                if (nomeAluno == item)
>>>>>>> bf09d4c547b20e54893837aaac03336014820daa
                {
                    if (item == nomeAluno)
                    {
                        this.Alunos[index] = "";
                        break;
                    }
                    index++;
                }
                return "Removido com sucesso";
            }
            return "Sala vazia";

        }

        public string MostrarAluno()
        {
            string listaAlunos = "";
            foreach (string item in this.Alunos)
            {
                if (item != "")
                {
<<<<<<< HEAD
                    listaAlunos = item;
                    // System.Console.WriteLine($"{count++} {listaAlunos}");
                }
            }
=======
                    listaAlunos = aluno;
                }
            }
            // listaAlunos.TrimEnd();
>>>>>>> bf09d4c547b20e54893837aaac03336014820daa
            return listaAlunos;
        }
    }
}