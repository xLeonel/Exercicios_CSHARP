using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Zé do Bar","123.456.789-00");
            Aluno aluno2 = new Aluno("Marry Jane", "548.410.154-00","Developer");

            Console.WriteLine("Nome: " + aluno1.Nome);
            Console.WriteLine("Curso: " + aluno1.Curso);
            Console.WriteLine("Curso: " + aluno1.Cpf);

            Console.WriteLine();

            Console.WriteLine("Nome: " + aluno2.Nome);
            Console.WriteLine("Curso: " + aluno2.Curso);
            Console.WriteLine("Curso: " + aluno2.Cpf);

            Console.Write("Entre com o Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Entre com o CPF: ");
            string Cpf = Console.ReadLine(); 
            Console.Write("Entre com o Curso: ");
            string Curso = Console.ReadLine();  
            Console.Write("Entre com a Nota: ");
            int Nota = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Bimestre: ");
            int bimestre = int.Parse(Console.ReadLine());
            Aluno aluno3 = new Aluno(Nome,Cpf,Curso);
            aluno3.setNotas(bimestre,nota);

            Console.WriteLine("Nome: " + aluno3.Nome);
            Console.WriteLine("Curso: " + aluno3.Curso);
            Console.WriteLine("Curso: " + aluno3.Cpf);
            Console.WriteLine("Notas: ");
            foreach (int n in aluno3.getNotas()){
               Console.Write(nota + " ");
            }
            Console.WriteLine();
        }
    }
}
