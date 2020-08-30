using System;

namespace ModificadoresREFeOUT {
    class Program {
        static void Main(string[] args) {

            //REF
            int a = 10;
            Modificador.valorTriplo(ref a);
            Console.WriteLine(a);

            //OUT
            int b = 10;
            Modificador.valorTripeOut(b, out b);
            Console.WriteLine(b);

            Console.ReadKey();

        }
    }
}
