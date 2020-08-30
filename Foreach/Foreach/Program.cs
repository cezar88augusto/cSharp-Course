using System;

namespace Foreach {
    class Program {
        static void Main(string[] args) {

            string[] vetor = new string[] { "Cézar", "Luísa", "MC" };

            //"Para cada elemento contido no vetor, 
            foreach (string elemento in vetor) {
                Console.WriteLine(elemento);
            }
            
        }
    }
}
