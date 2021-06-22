using System;
namespace _02___MANUAL___For {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Mostre os ímpares de 1 até X, um valor por linha.");
            int x = int.Parse(Console.ReadLine());
            for(int i = 1; i <= x; i++) {
                if(i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
