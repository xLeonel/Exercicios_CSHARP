using System;

namespace mcbonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Ze Burgues", "55 11 2541-2356", "ze@email.com");

            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Telefone: " + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Email);

            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
             Console.Write("Telefone: ");
            string Telefone = Console.ReadLine();
             Console.Write("Email: ");
            string Email = Console.ReadLine();

            Console.WriteLine();
          
          Cliente cliente2 = new Cliente(Nome, Telefone, Email);

            Console.WriteLine("Nome: " + cliente2.Nome);
            Console.WriteLine("Telefone: " + cliente2.Telefone);
            Console.WriteLine("Email: " + cliente2.Email);




            

        }
    }
}
