using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            try // Tentar executar
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException) // se der um tipo de erro, será exibida a msg abaixo
            {
                Console.WriteLine("Division by zero is not allowed!");
            }
            catch (FormatException) // se der outro tipo de erro, outra msg será exibida.
            {
                Console.WriteLine("Não use string!");
            }

            Console.ReadKey();
        }
    }
}
