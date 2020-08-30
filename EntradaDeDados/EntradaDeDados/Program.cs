using System;
using System.Globalization;

namespace EntradaDeDados {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite alguma coisa: ");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: ");

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("Digite algumas palavras: ");

            string s = Console.ReadLine();

            string[] vet = s.Split(' ');
            //OU
            //
            //string[] vet = Console.ReadLine().Split(' ');

            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //------ Converter dados utilizando o Split para recortar
            Console.WriteLine("Digite seu nome, sexo (F ou M), idade e altura ");

            string[] vet2 = Console.ReadLine().Split(' ');

            string nome = vet2[0];
            char sexo = char.Parse(vet2[1]);
            int idade = int.Parse(vet2[2]);
            double altura = double.Parse(vet2[3], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine();

            //------ Exercício

            Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa? ");
            int bedroom = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] vetor = Console.ReadLine().Split(' ');

            Console.WriteLine(name);
            Console.WriteLine(bedroom);
            Console.WriteLine(price);
            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(vetor[2]);   

            Console.ReadKey();

        }
    }
}
