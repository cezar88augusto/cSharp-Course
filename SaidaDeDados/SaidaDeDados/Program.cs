using System;
using System.Globalization;

namespace ConsoleApplication2 {
    class Program {
        static void Main(string[] args) {

            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();

            //Concatenação
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            //Placeholder
            Console.WriteLine("A paciente {0} tem {1} anos e seu sexo é {2} e seu salário atual é {3:F2}", z, y, w, x);
            //Interpolação
            Console.WriteLine($"A paciente {z} tem {y} anos e seu sexo é {w} e seu salário atual é {x:F2}");

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("");
            Console.WriteLine("Produtos");
            Console.WriteLine("{0} cujo preço é {1}", produto1, preco1);
            Console.WriteLine("{0} cujo preço é {1}", produto2, preco2);
            Console.WriteLine("");
            Console.WriteLine("{0} anos de idade, código {1} e gênero: M", idade, codigo, genero);
            Console.WriteLine("");
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (três casa decimais) " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
