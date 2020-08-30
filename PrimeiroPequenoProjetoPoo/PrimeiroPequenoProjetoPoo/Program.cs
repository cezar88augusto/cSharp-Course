using System;
using System.Globalization;
namespace PrimeiroPequenoProjetoPoo {
    class Program {
        static void Main(string[] args) {

            //Exemplo 1
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qtde = int.Parse(Console.ReadLine());
            p.Adicionar(qtde);
            Console.Write("Dados atualizados!" + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido: ");
            qtde = int.Parse(Console.ReadLine());
            p.Remover(qtde);
            Console.Write("Dados atualizados!" + p);
            Console.ReadKey();

            //Exemplo 2
            Aluno a = new Aluno();
            a.nota1 = 20;
            a.nota2 = 10;
            a.nota3 = 20;

            if (a.total() >= 60) {
                Console.WriteLine("Nota Final = " + a.total());
                Console.WriteLine("Aprovado!");
            }
            else {
                Console.WriteLine("Nota Final = " + a.total());
                Console.WriteLine("Reprovado!");
                double ptsFaltantes = 60 - a.total();
                Console.WriteLine("Faltaram {0} pontos", ptsFaltantes);
            }

            Console.ReadKey();

        }
    }
}
