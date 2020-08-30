using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadoresREFeOUT {
    class Modificador {

        public static int valorTriplo (ref int valor) {
            valor *= 3;
            return valor;
        }

        public static void valorTripeOut(int origin, out int result) {

            result = origin * 3;
        }
    }
}
