using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = true;
            do
            {
                Console.WriteLine("Escolha um Planeta que você queira ver seu peso (em Kg): ");
                System.Console.WriteLine();

                System.Console.WriteLine(" 1 - Mercúrio");
                System.Console.WriteLine(" 2 - Vênus");
                System.Console.WriteLine(" 3 - Marte");
                System.Console.WriteLine(" 4 - Júpiter");
                System.Console.WriteLine(" 5 - Saturno");
                System.Console.WriteLine(" 6 - Urano");
                System.Console.WriteLine(" 0 - Sair");

                int opçaoUser = int.Parse(Console.ReadLine());

                double massaCorporal;
                double Pplaneta;

                switch (opçaoUser)
                {
                    case 1:
                        System.Console.WriteLine("Qual seu peso?");
                        massaCorporal = double.Parse(Console.ReadLine());
                        Pplaneta = (massaCorporal / 10) * 0.37;
                        System.Console.WriteLine($"Seu peso em Mercúrio é {Pplaneta} Kg");
                        Console.ReadLine();
                        Repetir(querSair);
                        break;
                    case 2:
                        System.Console.WriteLine("Qual seu peso?");
                        massaCorporal = double.Parse(Console.ReadLine());
                        Pplaneta = (massaCorporal / 10) * 0.88;
                        System.Console.WriteLine($"Seu peso em Vênus é {massaCorporal} Kg");
                        Console.ReadLine();
                        Repetir(querSair);
                        break;
                    case 3:
                        System.Console.WriteLine("Qual seu peso?");
                        massaCorporal = double.Parse(Console.ReadLine());
                        Pplaneta = (massaCorporal / 10) * 0.38;
                        System.Console.WriteLine($"Seu peso em Marte é {massaCorporal} Kg");
                        Console.ReadLine();
                        Repetir(querSair);
                        break;
                    case 4:
                        System.Console.WriteLine("Qual seu peso?");
                        massaCorporal = double.Parse(Console.ReadLine());
                        Pplaneta = (massaCorporal / 10) * 2.64;
                        System.Console.WriteLine($"Seu peso em Júpiter é {massaCorporal} Kg");
                        Console.ReadLine();
                        Repetir(querSair);
                        break;
                    case 5:
                        System.Console.WriteLine("Qual seu peso?");
                        massaCorporal = double.Parse(Console.ReadLine());
                        Pplaneta = (massaCorporal / 10) * 1.15;
                        System.Console.WriteLine($"Seu peso em Saturno é {massaCorporal} Kg");
                        Console.ReadLine();
                        Repetir(querSair);
                        break;
                    case 6:
                        System.Console.WriteLine("Qual seu peso?");
                        massaCorporal = double.Parse(Console.ReadLine());
                        Pplaneta = (massaCorporal / 10) * 1.17;
                        System.Console.WriteLine($"Seu peso em Urano é {massaCorporal} Kg");
                        Console.ReadLine();
                        Repetir(querSair);
                        break;
                    case 0:
                        querSair = false;
                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida.");
                        massaCorporal = double.Parse(Console.ReadLine());
                        break;
                }
            } while (querSair);

        }
        public static void Repetir(bool querSair)
        {
            Console.Clear();
            System.Console.WriteLine("Você deseja ver seu peso em outro planeta?  ( S/N )");
            string repetir = Console.ReadLine();

            if (repetir == "n")
            {
                querSair = false;
            }
        }
    }
}
