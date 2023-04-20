using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Distribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string jsonText = File.ReadAllText(@"C:\giovanne\exercicios\faturamento.json");
            List<DiaFaturamento> faturamentoDiario = JsonConvert.DeserializeObject<List<DiaFaturamento>>(jsonText);

           
            decimal menorFaturamento = decimal.MaxValue;
            decimal maiorFaturamento = decimal.MinValue;

            foreach (DiaFaturamento dia in faturamentoDiario)
            {
                if (dia.Valor > maiorFaturamento)
                {
                    maiorFaturamento = dia.Valor;
                }

                if (dia.Valor < menorFaturamento && dia.Valor > 0)
                {
                    menorFaturamento = dia.Valor;
                }
            }

            Console.WriteLine($"Menor valor de faturamento: {menorFaturamento:C}");
            Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento:C}");

            
            decimal somaFaturamento = 0;
            int diasComFaturamento = 0;

            foreach (DiaFaturamento dia in faturamentoDiario)
            {
                if (dia.Valor > 0)
                {
                    somaFaturamento += dia.Valor;
                    diasComFaturamento++;
                }
            }

            decimal mediaFaturamento = somaFaturamento / diasComFaturamento;
            Console.WriteLine($"Média mensal de faturamento: {mediaFaturamento:C}");

            
            int diasAcimaDaMedia = 0;

            foreach (DiaFaturamento dia in faturamentoDiario)
            {
                if (dia.Valor > mediaFaturamento)
                {
                    diasAcimaDaMedia++;
                }
            }

            Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
        }
    }

    public class DiaFaturamento
    {
        public int Dia { get; set; }
        public decimal Valor { get; set; }
    }
}

