using System;

class Program {
    static void Main(string[] args) {
        string original = "exemplo"; 
        string invertida = ""; 

       
        for (int i = original.Length - 1; i >= 0; i--) {
            invertida += original[i];
        }

        Console.WriteLine("Original: " + original);
        Console.WriteLine("Invertida: " + invertida);
    }
}
