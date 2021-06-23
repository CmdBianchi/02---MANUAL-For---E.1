using System;
namespace _02___MANUAL___For {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Exercício 04 - estrutura repetitiva FOR - Lista de exercícios, mostre a divisão do primeiro pelo segundo.Se o denominador for igual a zero, mostrar a mensagem divisao impossivel.");
            int n = int.Parse(Console.ReadLine()); //----> Números de casos

            for (int i = 1; i <= n; i++) {
                Console.Write("Digite o valor X: "); double x = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor Y: "); double y = double.Parse(Console.ReadLine());

                if(y == 0) {
                    Console.WriteLine("Impossivel dividir");
                }
                else {
                    double z = x / y;
                    Console.WriteLine("------------------");
                    Console.WriteLine("Resultado: "+z);
                }
            }
        }
    }
}
