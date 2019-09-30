using System;
using MateODragao.Models;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args)
        {
            // INICIO-MENU 
            bool jogadorNaoDesistiu = true;
            do
            {
                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("        Mate o Dragão!");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine();

                System.Console.WriteLine(" 1 - Iniciar jogo");
                System.Console.WriteLine(" 0 - Sair do jogo");

                System.Console.WriteLine();

                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        Console.Clear();
                        Guerreiro guerreiro = new Guerreiro();
                        guerreiro.Nome = "Marla";
                        guerreiro.Sobrenome = "Singer";
                        guerreiro.CidadeNatal = "Buckinshcmit";
                        guerreiro.DataNascimento = DateTime.Parse("06/06/666");
                        guerreiro.FerramentaProtecao = "Capacete / Bracelete";
                        guerreiro.FerramenteAtaque = "Espada";
                        guerreiro.Forca = 1;
                        guerreiro.Destreza = 2;
                        guerreiro.Inteligencia = 5;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao();
                        dragao.Nome = "Agamenon";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        // INICIO - PRIMEIRO DIALOGO
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} {guerreiro.Sobrenome.ToUpper()}: {dragao.Nome}, seu louco! Vim-lhe derrotar-lhe!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Humano tolinho. Quem pensas que és?");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                        // FIM - PRIMEIRO DIALOGO

                        // INICIO - SEGUNDO DIALOGO 
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} {guerreiro.Sobrenome.ToUpper()}: Eu sou {guerreiro.Nome}! Da Casa {guerreiro.Sobrenome}, ó criatura morfética.");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} {guerreiro.Sobrenome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE? Bom, que seja... fritar-te-ei e devorar-te-ei, primata insolete! ");

                        System.Console.WriteLine();
                        System.Console.WriteLine("BAMBAM: Tá na hora do show!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                        // FIM - SEGUNDO DIALOGO

                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("--- Turno do Jogador ---");
                            System.Console.WriteLine();
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;


                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} {guerreiro.Sobrenome.ToUpper()}: Toma essa, largato MALDJEETO!");
                                        dragao.Vida -= (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"HP Dragao: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");

                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errrrrrou, humanóde tosco!");
                                    }
                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} {guerreiro.Sobrenome.ToUpper()}: To vazando, vlw flw!");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                        {
                            Console.Clear();
                            System.Console.WriteLine("--- Turno do Dragao ---");
                            Random geradorNumeroAleatorio = new Random();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;


                            if (dragaoDestrezaTotal > guerreiroDestrezaTotal)
                            {
                                System.Console.WriteLine($"{dragao.Nome.ToUpper()} : Fritou o forévis, foi?");
                                guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine($"HP Dragao: {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");

                            }
                            else
                            {
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} {guerreiro.Sobrenome.ToUpper()}: Errou, dragão feioso!");
                            }

                            System.Console.WriteLine();
                            System.Console.WriteLine("Aperte ENTER para prosseguir");
                            Console.ReadLine();

                            Console.Clear();

                            System.Console.WriteLine("--- Turno do Jogador ---");
                            System.Console.WriteLine();
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;


                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} {guerreiro.Sobrenome.ToUpper()}: Toma essa, largato MALDJEETO!");
                                        dragao.Vida -= (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"HP Dragao: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");

                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errrrrrou, humanóde tosco!");
                                    }
                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} {guerreiro.Sobrenome.ToUpper()}: To vazando, vlw flw!");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }
                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine("HASTA LA VISTA, BABY!");
                        break;
                    default:
                        System.Console.WriteLine("Comando inválido");
                        break;
                }
            } while (jogadorNaoDesistiu);


            // FIM-MENU



        }
    }
}
