using System;

namespace Byte_Bank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _Saldo;

        public double Saldo
        {
            get { return _Saldo; }
        }

        public ContaCorrente(int Agencia, int Numero, Cliente Titular)
        {
            this.Agencia = Agencia;
            this.Titular = Titular;
            this.Numero = Numero;
            this._Saldo = 0.0;
        }

        public double deposito(double valor)
        {
            return this._Saldo += valor; 
        }
        public bool saque(double valor)
        {
            if (this._Saldo >= valor)
            {
                this._Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool transferencia(ContaCorrente contaDestino, double valor)
        {
            if (this.saque(valor))
            {
                contaDestino.deposito(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}