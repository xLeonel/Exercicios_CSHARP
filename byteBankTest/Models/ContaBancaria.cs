using System;

namespace byteBankTest.Models
{
    public abstract class ContaBancaria
    {
        public string Titular;
        public int Agencia;
        public int NumeroConta;
        public double Saldo;

        public ContaBancaria (int Agencia, int NumeroConta, string Titular)
        {
            this.Agencia = Agencia;
            this.NumeroConta = NumeroConta;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }

        public abstract bool Saque (double Valor);
      
        public bool Deposito (double Valor)
        {
            if (Valor >= 0)
            {
                this.Saldo += Valor;
            }
            return true;
        }

        public bool Transferencia (ContaBancaria destino, double Valor)
        {
            if (this.Saldo(Valor))
            {
                destino.Deposito(Valor);
            }
            return true;
        }
    }
}