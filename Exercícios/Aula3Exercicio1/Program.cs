using System;
using System.Globalization;

namespace Aula3Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, precoTotalTerreno;
   
            // entrada de dados
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // calcular a área e preco area
            area = largura * comprimento;
            precoTotalTerreno = area * precoMetroQuadrado;

            // saída dos dados
            Console.WriteLine("AREA = " + area.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + precoTotalTerreno.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
