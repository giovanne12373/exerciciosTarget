using System;
using System.Collections.Generic;


{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> faturamentoPorEstado = new Dictionary<string, decimal>
            {
                {"SP", 67836.43m},
                {"RJ", 36678.66m},
                {"MG", 29229.88m},
                {"ES", 27165.48m},
                {"Outros", 19849.53m}
            };

            decimal totalFaturamento = 0;

            foreach (decimal valor in faturamentoPorEstado.Values)
            {
                totalFaturamento += valor;
            }

            Console.WriteLine($"Total mensal de faturamento: {totalFaturamento:C}");

            Console.WriteLine("\nPercentual de representação de cada estado:");

            foreach (KeyValuePair<string, decimal> estado in faturamentoPorEstado)
            {
                decimal percentual = estado.Value / totalFaturamento * 100;
                Console.WriteLine($"{estado.Key} - {percentual:F2}%");
            }
        }
    }
}
