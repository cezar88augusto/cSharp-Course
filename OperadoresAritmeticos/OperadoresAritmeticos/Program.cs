using System;

namespace OperadoresAritmeticos {
    class Program {
        static void Main(string[] args) {

            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1); // Resp 11

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2); // Resp 14

            int b3 = 17 % 3;
            Console.WriteLine(b3); // Resp 2

            //Delta
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            Console.ReadKey();
        }
    }
}
