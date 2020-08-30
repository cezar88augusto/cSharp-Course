using System;
using System.IO;

namespace Trabalhando_com_Pastas
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS:"); //Listar todas as pastas

                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FILES:"); // listar todos os arquivos

                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //Criar um diretório:

                Directory.CreateDirectory(@"c:\temp\myfolder\newfolder");

            }

            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
