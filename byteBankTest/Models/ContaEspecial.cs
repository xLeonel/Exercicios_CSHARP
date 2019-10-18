using System;

namespace byteBankTest.Models
{
    public class ContaEspecial : ContaBancaria
    {
        public double Limite;

        public ContaEspecial (int Agencia, int NumeroConta, string Titular) : base (Agencia, NumeroConta, Titular)
        {
            this.Limite = 0.0;
        }

        public bool SetLimite (double Limite)
        {
            if (Limite >= 0)
            {
                this.Limite = Limite;
                return true;
            }
            else
            {
                return  false;
            }
        }

        public override bool Saque(double Valor)
        {
            if (Valor >= 0)
            {
                if (Valor <= Saldo + this.Limite)
                {
                    this.Saldo -= Valor;
                    return true;
                }
            }
            return false;
        }

    }
}