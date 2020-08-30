using System;

namespace EstruturaCondicional {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            if(x == 0) {
                Console.WriteLine("Zero");
            }else if (x%2 == 0) {
                Console.WriteLine("Par");
            }
            else {
                Console.WriteLine("Ímpar");
            }

            Console.ReadKey();
        }
    }
}
