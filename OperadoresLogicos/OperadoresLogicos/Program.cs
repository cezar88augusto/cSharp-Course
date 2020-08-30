using System;

namespace OperadoresLogicos {
    class Program {
        static void Main(string[] args) {

            bool c1 = 4 != 5;
            Console.WriteLine(c1);

            bool c2 = 4 < 4 && 5 < 1;
            Console.WriteLine(c2);

            bool c3 = 5 > 6 || 5 < 8;
            Console.WriteLine(c3);

            bool c4 = !(5 > 3);
            Console.WriteLine(c4);

            //Ordem de precedência: resolve-se o && primeiro.
            bool c5 = c4 && c2 || c1;
            Console.WriteLine(c5);
           

        }
    }
}
