using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models

{
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercussao
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Violão");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo violao");
            return true;
        }
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo violao");
            return true;
        }
    }
}