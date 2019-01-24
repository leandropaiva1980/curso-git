using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Conta
    {
        private readonly double taxaSaque = 5;
        public double SaldoConta { get; private set; }
        public int NumeroDaConta { get; private set; }
        public string Correntista { get; set; }

        #region Construtores
        public Conta() { }

        public Conta(string correntista, int conta)
        {
            NumeroDaConta = conta;
            Correntista = correntista;
        }

        public Conta(string correntista, int conta, double depositoInicial) : this(correntista, conta)
        {
            Depositar(depositoInicial);
        }
        #endregion

        #region Métodos
        public void Depositar(double Valor)
        {
            if (Valor > 0) SaldoConta += Valor;
        }

        public void Sacar(double Valor)
        {
            if ((Valor > 0) && (SaldoConta > 0))
            {
                SaldoConta -= (Valor + taxaSaque);
            }
        }

        public override string ToString()
        {
            return $"Conta: {NumeroDaConta}, Titular: {Correntista}, " +
                   $"Saldo: R$ {SaldoConta.ToString("F2")}";
        }
        #endregion
    }
}