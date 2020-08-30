using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Properties {
    class Properties {

        //Como o nome possui uma lógica particular, não se colca o get and set
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Properties(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public void Adicionar(int quantidade) {
            Quantidade += quantidade;
        }

        public void Remover(int quantidade) {
            Quantidade -= quantidade;
        }

        public string Nome {
            get {
                return _nome;
            }

            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
                else {
                    Console.WriteLine("Valor digitado é nulo ou contém apenas uma letra.");
                }
            }
        } 

        public double ValorTotalEmEstoque() { return Preco * Quantidade; }
        public void AdicionarProdutos(int quantidade) { Quantidade += quantidade; }
        public void RemoverProdutos(int quantidade) { Quantidade -= quantidade; }
        public override string ToString() { return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); }


    }


}

