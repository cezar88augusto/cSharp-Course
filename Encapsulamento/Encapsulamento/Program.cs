using System;
using System.Collections.Concurrent;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {

            Encapsulamento produto = new Encapsulamento("TV", 500.00, 10);

            produto.SetNome("TV 4K");
            Console.WriteLine(produto);

            
        }
    }
}
