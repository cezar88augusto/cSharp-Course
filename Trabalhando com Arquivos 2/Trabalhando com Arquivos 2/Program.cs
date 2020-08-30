using System;
using System.IO;

namespace Trabalhando_com_Arquivos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Cézar\Desktop\arquivo1.txt";

            //ARQUIVO STREAM
            FileStream fs = null; // Objeto da classe FileStream

            //LEITOR DE ARQUIVO STREAM
            StreamReader sr = null; // Objeto da calsse StreamReader

            try
            {
                fs = new FileStream(path, FileMode.Open); // Caminho do arquivo + Modo de como eu quero instanciar o meu FileStream: ler? escrever?
                
                //FileMode.Open = ABRIR
                //FileMode.Append = ABRIR ARQUIVO PRA INSERIR DADO
                //FileMode.Create = RECRIAR O ARQUIVO

                sr = new StreamReader(fs);

               //sr = File.OpenText(path); TAMBÉM FUNCIONA ASSIM! 


                while (!sr.EndOfStream) // Enquanto o leitor de stream não estiver no final do arquivo, será lido a linha.
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
               

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }
            finally // Sempre fechar os streams.
            {
                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
