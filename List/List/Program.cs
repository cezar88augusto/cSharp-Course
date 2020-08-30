using System;
using System.Collections.Generic;

namespace List {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            //Add adiciona na posição final.
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Cézar");
            list.Add("Luísa");
            //Insert adiciona na posição que se quer.
            list.Insert(2, "Marco"); //empurra os outros elementos pra inseir este. 

            foreach (var item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine("Contar os elementos na lista: " + list.Count);

            //Expressão Lambda:
            //Eu quero o objeto x, tal que x na posição 0 seja igual a 'A'
            string name = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome com A: " + name);

            //Mesma coisa do Find, porém, pega-se a última posição.
            string name2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome com A: " + name2);

            //Primeira posição que começa com a algum caractere
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição que tem a letra 'A': " + pos1);

            //Última possição que começa com algum caractere
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição que tem a letra 'A': " + pos2);

            //Filtrar a lista: Criar uma nova lista contendo apenas os elementos que satisfação o predicado.

            //Ex: pegar os elementos de uma lista que contenham apenas 5 caracteres.

            List<string> list2 = list.FindAll(x => x.Length == 5);

            Console.WriteLine("-------");
            foreach (string item in list2) {
                Console.WriteLine(item);

            }
            Console.WriteLine("-------");

            //Remover elementos da lista

            Console.WriteLine("-------");
            list.Remove("Alex");
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");

            //Remover tudo, obedecendo uma condição

            Console.WriteLine("-------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");

            //Remover em uma posição especifica
            Console.WriteLine("-------");
            list.RemoveAt(1);
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");

            //Apartir da posição X eu quero remover X elementos

            //Remover em uma posição especifica
            Console.WriteLine("-------");
            list2.RemoveRange(2,2);
            foreach (var item in list2) {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");
        }
    }
}
