using System;

namespace AreaTrapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração das variáveis
            double b,B,h,area;

            // inicialização
            b = 8.0;
            B = 10.0;
            h = 12.0;

            // processamento
            area = (b + B) / 2.0 * h;
          
            Console.WriteLine("Área do trapézio: {0}", area);
            
        }
    }
}
