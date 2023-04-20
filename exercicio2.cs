using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program {
    static void Main(string[] args) {
        string json = File.ReadAllText("faturamento.json");
        decimal[] faturamento = JsonConvert.DeserializeObject<decimal[]>(json);

        decimal menor = faturamento.Min();
        decimal maior = faturamento.Max();
        decimal media = faturamento.Where(valor => valor > 0).Average();

        int diasAcimaDaMedia = faturamento.Count(valor => valor > media);

        Console.WriteLine($"Menor faturamento: {menor}");
        Console.WriteLine($"Maior faturamento: {maior}");
        Console.WriteLine($"Dias acima da média: {diasAcimaDaMedia}");
    }
}
