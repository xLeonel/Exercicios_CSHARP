using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;

            do {
                //MENUZAO//

                Console.WriteLine("Calcular área do Quadrado -- Q");
                Console.WriteLine("Calcular área do Triângulo -- T");
                Console.WriteLine("Calcular área do Círculo -- C");
                Console.WriteLine("Calcular área do Trapézio -- Tr");
                Console.WriteLine("Calcular área do Retângulo -- R");
                Console.WriteLine("Calcular área do Losango -- L");
                Console.WriteLine("Digite end para fechar o programa.");


                escolha = Console.ReadLine();

                switch (escolha) {
                    
                    //////////////////////////////////////AREA QUADRADO/////////////////////////////////////////////////
                    case "q":  
                    case "Q":
			        Console.WriteLine("Você escolheu Área do Quadrado");

                    Console.Write("Escreva o lado: ");
                    double baseQuad = double.Parse(Console.ReadLine());
        
                    double areaTotalQuad = baseQuad * baseQuad ;

                    Console.WriteLine("Área do Quadrado: " + areaTotalQuad + " m²");
                    Console.WriteLine();
			        break;
                    //////////////////////////////////////AREA QUADRADO/////////////////////////////////////////////////
                    
                    //////////////////////////////////////AREA Triangulo/////////////////////////////////////////////////
                    case "t":  
                    case "T":
			        Console.WriteLine("Você escolheu Área do Triângulo");

                    Console.Write("Escreva a Base: ");
                    double baseTri = double.Parse(Console.ReadLine());
                    Console.Write("Escreva a Altura: ");
                    double alturaTri = double.Parse(Console.ReadLine());

                    double areaTotalTri = (baseTri * alturaTri) / 2 ;

                    Console.WriteLine("Área do Triângulo: " + areaTotalTri + " m²");
                    Console.WriteLine();
			        break;
                    //////////////////////////////////////AREA Triangulo/////////////////////////////////////////////////

                    //////////////////////////////////////AREA Circulo/////////////////////////////////////////////////
                    case "c":  
                    case "C":
			        Console.Write("Você escolheu Área do Círculo");

                    Console.Write("Escreva o Raio: ");
                    double raioCir = double.Parse(Console.ReadLine());

                    double pi = 3.14;

                    double areaTotalCir = pi * (raioCir * raioCir)  ;

                    Console.WriteLine("Área do Círculo: " + areaTotalCir + " m²");
                    Console.WriteLine();
			        break;
                    //////////////////////////////////////AREA Circulo/////////////////////////////////////////////////

                    //////////////////////////////////////AREA Trapezio/////////////////////////////////////////////////
                    case "tr":  
                    case "Tr":
                    case "TR":  
                    case "tR":
			        Console.WriteLine("Você escolheu Área do Trapézio");

                    Console.Write("Escreva a Base-Maior: ");
                    double baseMaiorTrap = double.Parse(Console.ReadLine());
                    Console.Write("Escreva a Base-Menor: ");
                    double baseMenorTrap = double.Parse(Console.ReadLine());
                    Console.Write("Escreva a Altura: ");
                    double alturaTrap = double.Parse(Console.ReadLine());


                    double areaTotalTrap = (baseMaiorTrap + baseMenorTrap) * alturaTrap / 2 ;

                    Console.WriteLine("Área do Trapézio: " + areaTotalTrap + " m²");
                    Console.WriteLine();
			        break;
                    //////////////////////////////////////AREA Trapezio/////////////////////////////////////////////////

                    //////////////////////////////////////AREA Retangulo/////////////////////////////////////////////////
                    case "r":  
                    case "R":
			        Console.WriteLine("Você escolheu Área do Retângulo");

                    Console.Write("Escreva a Base: ");
                    double baseRet = double.Parse(Console.ReadLine());
                    Console.Write("Escreva a Altura: ");
                    double alturaRet = double.Parse(Console.ReadLine());

                    double areaTotalRet = baseRet * alturaRet;

                    Console.WriteLine("Área do Retângulo: " + areaTotalRet + " m²");
                    Console.WriteLine();
			        break;
                    //////////////////////////////////////AREA Rentagulo/////////////////////////////////////////////////
                    
                    //////////////////////////////////////AREA Losango/////////////////////////////////////////////////
                    case "l":  
                    case "L":
			        Console.WriteLine("Você escolheu Área do Losango");

                    Console.Write("Escreva o Diâmetro-Maior: ");
                    double diamentroMaiorLos = double.Parse(Console.ReadLine());
                    Console.Write("Escreva o Diâmetro-Menor: ");
                    double diamentroMenorLos = double.Parse(Console.ReadLine());

                
                    double areaTotalLos = ( diamentroMaiorLos * diamentroMenorLos )  / 2 ;

                    Console.WriteLine("Área do Losango: " + areaTotalLos + " m²");
                    Console.WriteLine();
			        break;
                    //////////////////////////////////////AREA Losango/////////////////////////////////////////////////
                }

            }  while ( escolha != "end");
        }
    }
}
