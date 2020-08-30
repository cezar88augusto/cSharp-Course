using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancáriaPoo {
    class Conta {

        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int conta, string titular) {
            NumeroConta = conta;
            Titular = titular;
        }

        public Conta(int conta, string titular, double deposito) : this (conta, titular) {
            depositar(deposito);
        }

        public void depositar(double valor) {
            Saldo += valor;
        }

        public void sacar(double valor) {
            Saldo = (Saldo - 5) - valor;
        }

        public override string ToString() {
            return "Conta: "
                + NumeroConta
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
