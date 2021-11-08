using System;

namespace Aula2CalculoTrapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracao de variaveis
            double b,B, h, area;
            // inicialização
            b = 6.0;
            B = 8.0;
            h = 5.0;
            // processamento
            area = (b + B) / 2.0 * h;

            // saída
            Console.WriteLine(area);

        }
    }
}
