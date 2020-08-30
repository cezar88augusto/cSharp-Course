﻿using System;
using System.Globalization;

namespace TrianguloComClasse {
    class Program {
        static void Main(string[] args) {

            //Exercício 1
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double areaX = x.Area();
            double areaY = y.Area();

   
            Console.WriteLine(areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("A maior área é: X");
            }
            else {
                Console.WriteLine("A maior área é: Y");
            }

       

        }
    }
}
