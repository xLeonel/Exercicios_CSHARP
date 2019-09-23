using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string loginAdm = "admin";
            string passAdm = "admin";

            Console.Write("Entre com o usuário: ");
            string login = Console.ReadLine();
            Console.Write("Entre com a senha: ");
            string passwd = Console.ReadLine();
    
            if ((login == loginAdm) && (passwd == passAdm )) {
                Console.WriteLine("Bem-vindo admnistrador.");

            } else {
                Console.WriteLine("Bem-vindo usuário.");
            }    
        }
    }
}
