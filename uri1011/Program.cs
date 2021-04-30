using System;
using System.Globalization;

namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de variáveis
            double volume, R, pi = 3.14159;

            // entrada de dados
            R = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // processamento
            volume = (4.0 / 3) * pi * R * R * R;
            
            // saída de dados
            // VOLUME = 113.097
            Console.WriteLine("VOLUME = "+ volume.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
