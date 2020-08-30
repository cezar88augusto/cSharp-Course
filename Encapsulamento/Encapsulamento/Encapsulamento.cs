﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Encapsulamento {
    class Encapsulamento {

        private string _nome;
        private double _preco;
        private int _quantidade;

        public Encapsulamento(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public void Adicionar(int quantidade) {
            _quantidade += quantidade;
        }

        public void Remover(int quantidade) {
            _quantidade -= quantidade;
        }

        public string GetNome() {
            return _nome;
        }

        public double GetPreco() {
            return _preco;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
            else {
                Console.WriteLine("Valor digitado é nulo ou contém apenas uma letra.");
            }
        }

        public double ValorTotalEmEstoque() { return _preco * _quantidade; }
        public void AdicionarProdutos(int quantidade) { _quantidade += quantidade; }
        public void RemoverProdutos(int quantidade) { _quantidade -= quantidade; }
        public override string ToString() { return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); }

    }

}
