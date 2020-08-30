using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticosComClasse {
    class ConversorDeMoeda {

        public static double dolarReal = 5.22;

        public static double Calculo(double quantia) {

            return (quantia * dolarReal) * 1.06; 

        }
    }
}
