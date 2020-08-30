using System;

namespace Properties {
    class Program {
        static void Main(string[] args) {
            Properties produto = new Properties("TV", 500, 5);

            produto.Nome = "TV 4K";

            Console.WriteLine(produto);

           
           
            Console.ReadKey();
        }
    }
}
