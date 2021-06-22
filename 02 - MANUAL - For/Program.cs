using System;
namespace _02___MANUAL___For {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Mostre quantos destes valores X estão dentro do intervalo [10,20].");
            Console.WriteLine("------------------------------");
            Console.Write("Digite o tamanho do intervalo: "); int n = int.Parse(Console.ReadLine());
            int contIn = 0;
            int contOut = 0;
            
            for(int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    contIn = contIn + 1;
                }
                else {
                    contOut = contOut + 1;
                }
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine(contIn +" in");
            Console.WriteLine(contOut + " out");
        }
    }
}
