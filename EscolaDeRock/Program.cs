using System;
using EscolaDeRock.Models;
using System.Collections.Generic;

namespace EscolaDeRock
{
    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO,
    };

    enum IntrumentosEnum : int
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLAO
    };

    enum CategoriaEnum : int
    {
        HARMONIA,
        PERCUSSAO,
        MELODIA
    };

    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = true;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(FormacaoEnum));

            var opçoesFormacao = new List<string>()
            {
                "     - 0                            ",
                "     - 1                            "
            };

            int opçaoFormaçaoSelecionada = 0;
            string menuBar = "===============================";

            do
            {
                bool formaçaoEscolhida = true;

                do
                {
                    Console.Clear();
                    System.Console.WriteLine(menuBar);
                    System.Console.BackgroundColor = ConsoleColor.DarkCyan;
                    System.Console.BackgroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("    Seja Bem-Vindo         ");
                    System.Console.WriteLine("    Escolha uma formção:   ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    for (int i = 0; i < opçoesFormacao.Count; i++)
                    {
                        string titulo = itensMenuPrincipal[i];
                        if (opçaoFormaçaoSelecionada == i)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine(opçoesFormacao[opçaoFormaçaoSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                            Console.ResetColor();
                        }
                        else
                        {
                            System.Console.WriteLine(opçoesFormacao[i].Replace(i.ToString(), titulo));
                        }
                    }

                    var key = Console.ReadKey(true).Key;

                    switch(key)
                    {
                        case ConsoleKey.UpArrow:
                        opçaoFormaçaoSelecionada = opçaoFormaçaoSelecionada == 0 ? opçaoFormaçaoSelecionada : --opçaoFormaçaoSelecionada;
                        break;
                        
                        case ConsoleKey.DownArrow:
                        opçaoFormaçaoSelecionada = opçaoFormaçaoSelecionada == opçoesFormacao.Count - 1 ? opçaoFormaçaoSelecionada : ++opçaoFormaçaoSelecionada;
                        break;

                        case ConsoleKey.Enter:
                        formaçaoEscolhida = true;
                        break;
                    }

                } while (true);
            } while (!querSair);
        }
    }
}
