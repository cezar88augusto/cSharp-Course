using System;

namespace Enquanto {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um número");

            int numero = int.Parse(Console.ReadLine());

            while (numero < 10) {
                numero++;
                Console.WriteLine(numero);
            }

            // Exercício 1

            //Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, 
            //escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" 
            //e o algoritmo encerrado. Considere que a senha correta é o valor 2002. 

            Console.Write("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {

                Console.Write("Senha inválida! Digite novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Senha correta!");

            // Exercício 2

            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 
            //1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até que seja válido). 
            //O programa será encerrado quando o código informado for o número 4.Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.

            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            Console.WriteLine("Digite o código do combustível: [1] Gasolina / [2] Álcool / [3] Diesel / [4] Sair");
            int codigo = int.Parse(Console.ReadLine());

            while (codigo < 1 || codigo > 4) {
                Console.WriteLine("Favor digitar um dos seguintes códigos: [1] Gasolina / [2] Álcool / [3] Diesel / [4] Sair");
                codigo = int.Parse(Console.ReadLine());
            }

            while (codigo != 4) {

                if (codigo == 1) {
                    gasolina++;
                }
                else if (codigo == 2) {
                    alcool++;
                }
                else {
                    diesel++;
                }

                Console.WriteLine("Digite o código do combustível: [1] Gasolina / [2] Álcool / [3] Diesel");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Diesel: " + diesel);



            Console.ReadKey();

        }
    }
}
