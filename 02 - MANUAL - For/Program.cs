﻿using System;
namespace _02___MANUAL___For {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Exercício 05 - Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.");
            Console.Write("Digite o tamanho do FATORIAL: "); int n = int.Parse(Console.ReadLine()); //----> Números de casos
            int fat = 1;
            for (int i = 1; i <= n; i++) {
                fat = fat * i;                
            }
            Console.WriteLine(fat);
        }
    }
}
