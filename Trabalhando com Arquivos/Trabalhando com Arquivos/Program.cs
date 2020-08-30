using System;
using System.IO; // Colocar esta biblioteca.

namespace Trabalhando_com_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Cézar\Desktop\arquivo1.txt";
            string targetPath = @"C:\Users\Cézar\Desktop\arquivo2.txt";

            // Poder colocar o caminho do arquivo assim também:
            // string sourcePath = "C:\\Users\\Cézar\\Desktop\\arquivo1.txt";

            try
            {
                //Instanciar um objeto do tipo FileInfo
                FileInfo fileInfo = new FileInfo(sourcePath); // Recebendo como argumento o string com o caminho;
                fileInfo.CopyTo(targetPath); // Copiada o arquivo

                string[] lines = File.ReadAllLines(sourcePath); // Ler cada linha do arquivo passado como parâmetro e guardar no vetor de strings.

                foreach (string line in lines) // Para cada linha no vetor lines, será exibida uma msg para cada linha.
                {
                    Console.WriteLine(line);
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
