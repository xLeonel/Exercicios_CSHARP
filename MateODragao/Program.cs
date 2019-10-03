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

                        Guerreiro guerreiro = CriarGuerreiro();

                        Dragao dragao = CriarDragao();

                        // INICIO - PRIMEIRO DIALOGO
                        CriarDialogo(guerreiro.Nome, $"{dragao.Nome}, seu louco! Vim-lhe derrotar-lhe!");
                        CriarDialogo(dragao.Nome, "Humano tolinho. Quem pensas que és?");

                        FinalizarDialogo();
                        // FIM - PRIMEIRO DIALOGO

                        // INICIO - SEGUNDO DIALOGO 
                        
                        CriarDialogo(guerreiro.Nome, $"Eu sou {guerreiro.Nome}! Da Casa {guerreiro.Sobrenome}, ó criatura morfética.");
                        CriarDialogo(guerreiro.Nome, $"Vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor!");
                        CriarDialogo(dragao.Nome, "QUEM? DE ONDE? Bom, que seja... fritar-te-ei e devorar-te-ei, primata insolente!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("BAMBAM: Tá na hora do show!");

                        FinalizarDialogo();

                        // FIM - SEGUNDO DIALOGO

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        bool jogadorNaoCorreu = true;

                        Random geradorNumeroAleatorio = new Random();
                        int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                        int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                        int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                        int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

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
                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        CriarDialogo(guerreiro.Nome, "Toma essa, largato MALDJEETO!");
                                        dragao.Vida -= (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"HP Dragao: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");

                                    }
                                    else
                                    {
                                        CriarDialogo(dragao.Nome, "Errrrrrou, humanóde tosco!");
                                        System.Console.WriteLine($"HP Dragao: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    break;
                                case "2":
                                    CriarDialogo(guerreiro.Nome, "To vazando, vlw flw!");
                                    CriarDialogo(dragao.Nome, "Muito Fácil!");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        FinalizarDialogo();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                        {
                            Console.Clear();
                            System.Console.WriteLine("--- Turno do Dragao ---");
                            geradorNumeroAleatorio = new Random();
                            numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;


                            if (dragaoDestrezaTotal > guerreiroDestrezaTotal)
                            {
                                CriarDialogo(dragao.Nome, "Fritou o forévis, foi?");
                                guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine($"HP Dragao: {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");

                            }
                            else
                            {
                                CriarDialogo(guerreiro.Nome, "Errou, dragão feioso!");
                            }

                            FinalizarDialogo();

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
                                        CriarDialogo(guerreiro.Nome, "Toma essa, largato MALDJEETO!");
                                        dragao.Vida -= (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"HP Dragao: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        CriarDialogo(dragao.Nome, "Errrrrrou, humanóde tosco!");
                                    }
                                    break;
                                case "2":
                                    CriarDialogo(guerreiro.Nome, "To vazando, vlw flw!");
                                    CriarDialogo(dragao.Nome, "Izi pizi ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        if (guerreiro.Vida <= 0)
                        {
                            System.Console.WriteLine("Você perdeu!");
                        }
                        if (dragao.Vida <= 0)
                        {
                            System.Console.WriteLine("Você ganhou!");
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

        public static void CriarDialogo(string nome, string frase)
        {
            System.Console.WriteLine($"{nome.ToUpper()}: \n - {frase}");
        }

        public static void FinalizarDialogo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte ENTER para prosseguir");
            Console.ReadLine();
            Console.Clear();
        }

        public static Guerreiro CriarGuerreiro()
        {
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

            return guerreiro;
        }

        public static Dragao CriarDragao()
        {
            Dragao dragao = new Dragao();
            dragao.Nome = "Agamenon";
            dragao.Forca = 5;
            dragao.Destreza = 1;
            dragao.Inteligencia = 3;
            dragao.Vida = 300;

            return dragao;
        }
    }
}
