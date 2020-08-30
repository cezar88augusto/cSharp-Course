using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroPequenoProjetoPoo {
    class Aluno {

        public string Nome;
        public double nota1, nota2, nota3;
        public double somaNotas;

        public double total() {

            somaNotas = nota1 + nota2 + nota3;
            return somaNotas;
        }




    }
}
