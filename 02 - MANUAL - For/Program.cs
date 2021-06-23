using System;
namespace _02___MANUAL___For {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.");
            Console.Write("Digite um número inteiro positivo N: "); int n = int.Parse(Console.ReadLine()); //----> Números de casos

            int soma = 0;
            for (int i = 1; i <= n; i++) {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}
