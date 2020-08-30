using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Construtores {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor normal
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Sobrecarregar

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public Produto() {

        }

        public double ValorTotalEmEstoque() { return Preco * Quantidade; }
        public void AdicionarProdutos(int quantidade) { Quantidade += quantidade; }
        public void RemoverProdutos(int quantidade) { Quantidade -= quantidade; }
        public override string ToString() { return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); }

    }
}
