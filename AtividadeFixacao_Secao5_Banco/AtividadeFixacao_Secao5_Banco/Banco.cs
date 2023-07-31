using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeFixacao_Secao5_Banco
{
    class Banco
    {
        public int Conta { get ; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Banco(int conta, string titular){
            Conta = conta;
            Titular = titular;
        }

        public Banco(int conta, string titular, double depositoInicial) : this (conta, titular)
        {
            DepositoConta(depositoInicial);
        }
              
        
        public void DepositoConta(double valorDeposito) {
            Saldo += valorDeposito;
        }

        public void SaqueConta(double valorSaque) {
            int taxa = 5;
            Saldo -= valorSaque + taxa;
        }

        public override string ToString() { 
            return "Conta " + Conta + ", Titular: " + Titular + ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
