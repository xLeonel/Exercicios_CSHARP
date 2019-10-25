using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira seu nome: ");
            string nameUser = Console.ReadLine();
            Console.WriteLine("Qual seu peso? (em Kg)");
            double peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual sua altura? (em metros)");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 20)
            {
                System.Console.WriteLine($"Nome: {nameUser}");
                System.Console.WriteLine($"Seu imc é {imc}");
                Console.WriteLine("Peso abaixo do normal");
            }
            else if ((imc >= 20) || (imc <= 25))
            {
                System.Console.WriteLine($"Nome: {nameUser}");
                System.Console.WriteLine($"Seu imc é {imc}");
                Console.WriteLine("Peso normal");
            }
            if ((imc > 25) || (imc < 30))
            {
                System.Console.WriteLine($"Nome: {nameUser}");
                System.Console.WriteLine($"Seu imc é {imc}");
                Console.WriteLine("Sobre o Peso");
            }
            else if ((imc >= 30) || (imc <= 35))
            {
                System.Console.WriteLine($"Nome: {nameUser}");
                System.Console.WriteLine($"Seu imc é {imc}");
                Console.WriteLine("Obesidade");
            }
            if ((imc > 35))
            {
                System.Console.WriteLine($"Nome: {nameUser}");
                System.Console.WriteLine($"Seu imc é {imc}");
                Console.WriteLine("Obesidade mórbida");
            }
        }
    }
}
