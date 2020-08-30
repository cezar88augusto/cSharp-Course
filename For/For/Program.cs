using System;

namespace For {
    class Program {
        static void Main(string[] args) {
            int somador = 0;

            //Somador
            Console.Write("Informe a quantidade de números que deseja somar: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++) {
                Console.Write("Número {0}: ", i);
                int numero = int.Parse(Console.ReadLine());
                somador += numero;
            }
            Console.WriteLine("Soma dos números: " + somador);
            Console.WriteLine();

            //Ímpares
            Console.Write("Informe um valor para visualizar os valores ímpares de 1 até o valor informado: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < valor; i++) {
                if (i % 2 == 1) {
                    Console.WriteLine(i);
                }
            }

            //Informar a quantidade de números. E o programa deve calcular a quantidade de valores dentro de um intervalo de 10 a 20. Quantidade fora deste intervalo.
            Console.Write("Informe a quantidade de valores: ");
            int valor2 = int.Parse(Console.ReadLine());
            int vIn = 0;
            int vOut = 0;

            for (int i = 0; i < valor2; i++) {
                if (i >= 10 && i <= 20) {
                    vIn++;
                }
                else {
                    vOut++;
                }
            }

            Console.WriteLine("Dentro do intervalo (10 a 20) : {0} / Fora do intervalo : {1} ", vIn, vOut);

            //Fatorial
            Console.Write("Digite um número para calcular o fatorial: ");
            int num = int.Parse(Console.ReadLine());
            int resultado = num;

            for (int i = num; i >= 1; i--) {

                if (i - 1 != 0) {

                    resultado *= i - 1;
                }
            }

            Console.WriteLine("Fatorial de {0} é {1}", num, resultado);

            //Calculo divisores em um intervalo:
            Console.Write("Digite um número para calcular seus divisores entre 1 e o valor digitado: ");
            int numInformado = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numInformado; i++) {
                if (numInformado % i == 0) {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}
