using System;

namespace Matriz {
    class Program {
        static void Main(string[] args) {

            /*Console.Write("Digite o tamanho da matriz de N (nxn): ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < mat.GetLength(0); i++) {
                Console.WriteLine("Digite os valores da {0}ª linha separando-os por um espaço: ", i + 1);
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < mat.GetLength(1); j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }


            //Mostrando a diagonal principal 

            for (int i = 0; i < mat.GetLength(0); i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {
                    if (i == j) {
                        Console.WriteLine(mat[i,j]);
                    }
                }
            }*/

            // Exercício

            Console.Write("Digite o número de linhas: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas: ");
            int coluna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linha, coluna];

            for (int i = 0; i < matriz.GetLength(0); i++) {

                Console.WriteLine("Digite os valores da {0}ª linha separando-os por um espaço: ", i + 1);

                string[] valores = Console.ReadLine().Split(" ");

                for (int j = 0; j < matriz.GetLength(1); j++) {

                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Qual número deseja buscar? ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {

                    if (matriz[i, j] == numero) {
                        Console.WriteLine("Position: Line {0} Col {1}", i, j);
                        if (j - 1 >= 0) {
                            Console.WriteLine("Left: {0}", matriz[i, j - 1]);
                        }
                        if (j + 1 < coluna) {
                            Console.WriteLine("Right: {0}", matriz[i, j + 1]);
                        }
                        if (i - 1 >= 0) {
                            Console.WriteLine("Up: {0}", matriz[i - 1, j]);
                        }
                        if (i + 1 < linha) {
                            Console.WriteLine("Down: {0}", matriz[i + 1, j]);
                        }
                    }
                }
            }



        }
    }
}
