﻿using System;

namespace Ternario {
    class Program {
        static void Main(string[] args) {
            
            double preco = 100;

            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

        }
    }
}
