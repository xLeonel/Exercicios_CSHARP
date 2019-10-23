using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Qual a velocidade do veículo (em km/h): ");
            double velocidadeCarro = double.Parse(Console.ReadLine());
            System.Console.Write("Digite o tempo gasto na viagem (em minutos): ");
            double tempoViagem = double.Parse(Console.ReadLine());

            double distanciaPercorrida = tempoViagem * velocidadeCarro;
            double combustivelGasto = distanciaPercorrida / 12;

            System.Console.WriteLine();
            System.Console.WriteLine($"Velocidade Média: {velocidadeCarro / 3.6} m/s");
            System.Console.WriteLine($"Tempo gasto na viagem: {tempoViagem} min");
            System.Console.WriteLine($"Distância percorrida: {distanciaPercorrida / 1000} Km");
            System.Console.WriteLine($"Combustível gasto: {combustivelGasto} L");

        }
    }
}
