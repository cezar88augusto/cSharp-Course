using System;

namespace VetorDeObjetos {
    class Program {
        static void Main(string[] args) {

            Inquilino[] vet = new Inquilino[10];

            Console.Write("Quantos quartos desejas alugar? ");
            int rooms = int.Parse(Console.ReadLine());

            for (int i = 0; i < rooms; i++) {

                Console.Write("Qual nome do {0}º hospede ? ", i+1);
                string nome = Console.ReadLine();
                Console.Write("Qual email do {0}º hospede ? ", i+1);
                string email = Console.ReadLine();
                Console.Write("Qual o quarto do {0}º hospede ? ", i+1);
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vet[i] = new Inquilino { name = nome, email = email, room = quarto };

            }

            for (int i = 0; i < vet.Length; i++) {
                if (vet[i] != null) {
                    Console.WriteLine(vet[i].room+": " + vet[i].name + "," + vet[i].email);
                }
            }

            Console.ReadKey();
            
        }
    }
}
