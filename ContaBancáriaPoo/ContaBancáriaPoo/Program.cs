using System;

namespace ContaBancáriaPoo {
    class Program {
        static void Main(string[] args) {

            Conta conta;

            Console.Write("Número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? [S/N]: ");
            string resp = Console.ReadLine();


            if (resp == "S" || resp == "s") {
                Console.Write("Entre com o valor de depósito inicial: ");
                double valorDepositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(numeroConta, nome, valorDepositoInicial);
            }
            else {
                conta = new Conta(numeroConta, nome);
            }

            Console.WriteLine(conta);

            Console.Write("Entre com um valor de depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.depositar(valorDeposito);
            Console.WriteLine("Saldo atualizado!");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor de saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.sacar(valorSaque);
            Console.WriteLine("Saldo atualizado!");
            Console.WriteLine(conta);

            Console.ReadKey();
        }
    }
}
