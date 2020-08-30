using System;
using System.Globalization;

namespace MembrosEstaticosComClasse {
    class Program {
        static void Main(string[] args) {


            //Exemplo 1

            Console.Write("Entre o valor do raio: "); 
            
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio); 
            
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture)); 

            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

            //Exemplo 2

            Console.Write("Informe a quantidade de dólar que deseja comprar: " );
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.Calculo(quantidade);

            Console.WriteLine(total);

        }
    }
}
