using System;
using System.Globalization;
namespace Vetor {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("EXEMPLO 1 - VETOR DO TIPO STRUCT");

            Console.Write("Digite a quantidade de alturas para calcular a média: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            
            double[] vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Altura {0}: ", i+1);
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vet[i];
            }

            double media = sum/n;

            Console.WriteLine("Média: " + media.ToString("F2"));

            //--------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("EXEMPLO 2 - VETOR DO TIPO OBJETO");

            Console.Write("Digite a quantidade de produtos para calcular a média: ");
            int n2 = int.Parse(Console.ReadLine());
            double sum2 = 0.0;

            Produto[] vet2 = new Produto[n2];

            for (int i = 0; i < n2; i++) {
                Console.Write("Nome do Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do Produto: ");
                double precoProduto = double.Parse(Console.ReadLine());
                vet2[i] = new Produto { name = nomeProduto, price = precoProduto }; //construtor nativo da classe Produto
                sum2 += vet2[i].price;
            }

            double media2 = sum2 / n2;
            Console.WriteLine("Média: " + media2.ToString("F2"));

            Console.ReadKey();

        }
    }
}
