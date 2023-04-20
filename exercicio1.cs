using System;

class Program {
    static void Main(string[] args) {
        int numero = 21; // número a ser verificado
        bool pertence = PertenceAoFibonacci(number);
        Console.WriteLine($"O número {number} {(pertence ? "pertence" : "não pertence")} à sequência de Fibonacci.");
    }

    static bool PertenceAoFibonacci(int number) {
        int a = 0, b = 1, c = 1;
        while (c < number) {
            a = b;
            b = c;
            c = a + b;
        }
        return (c == number);
    }
}
