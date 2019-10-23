using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite a altura do retângulo: ");
            double alturaRetangulo = double.Parse(Console.ReadLine());
            System.Console.Write("Digite a base do retângulo: ");
            double baseRetangulo = double.Parse(Console.ReadLine());

            double perimetroRetangulo = (alturaRetangulo + baseRetangulo) * 2;
            double areaRetangulo = baseRetangulo * alturaRetangulo;
            double diagonalRetangulo = (baseRetangulo * baseRetangulo) + (alturaRetangulo * alturaRetangulo);
            diagonalRetangulo = Math.Sqrt(diagonalRetangulo);

            System.Console.WriteLine($"Perímetro: {perimetroRetangulo}");
            System.Console.WriteLine($"Área: {areaRetangulo}");
            System.Console.WriteLine($"Diagonal: {diagonalRetangulo}");
        }
    }
}
