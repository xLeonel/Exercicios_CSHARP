namespace byteBankTest.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int Agencia, int NumeroConta, string Titular) : base(Agencia, NumeroConta, Titular)
        {

        }

        public override bool Saque(double Valor)
        {
            if (Valor >= 0)
            {
                if (Valor <= Saldo)
                {
                    this.Saldo -= Valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}