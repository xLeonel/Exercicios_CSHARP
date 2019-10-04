namespace byteBank.Models
{
    public class ContaCorrente
    {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente(int Agencia, int Conta, string Titular)
        {
            this.Agencia = Agencia;
            this.Conta = Conta;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }

        public double DepositarDinheiro(double deposito)
        {
            return this.Saldo += deposito;
        }
        public bool SacarDinheiro(double saque)
        {
            if (saque < Saldo)
            {
                this.Saldo -= saque;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferirDinheiro(ContaCorrente contaDestino, double transferencia)
        {
           if(this.SacarDinheiro(saque) {
               contaDestino.DepositarDinheiro(deposito);
               return true;
           }
            
        }
    


    }
}