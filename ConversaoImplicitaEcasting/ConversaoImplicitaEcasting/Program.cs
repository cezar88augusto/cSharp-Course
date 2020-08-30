using System;

namespace ConversaoImplicitaEcasting {
    class Program {
        static void Main(string[] args) {

            //Conversão implícita de tipos
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);
            //Conversão casting
            double a;
            float b;

            a = 5.1;
            //b = a; //Não funciona: a tem 8bytes e b tem 4bytes;

            //Funciona assim:
            b = (float)a;

            //--------------------------------

            int n1 = 5;
            int n2 = 2;
            double resultado = (double)a/b;
            Console.WriteLine(resultado);

        }
    }
}
