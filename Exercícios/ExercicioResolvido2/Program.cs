using System;
using System.Globalization;

namespace ExercicioResolvido2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler as medidas da base e altura de um retangulo. 
            // Em seguindo, mostrar, o valor da área, perímetro e diagonal deste retangulo, com quatro
            // casas decimais conforme exemplo.
            // base: 5
            // altura: 4
            // AREA = 20.0000 a = b x a
            // PERIMETRO = 18.0000 2 x b + 2 x a
            // DIAGONAL = 6.4031 raiz  de b2 + a2

            double b, a, area, perimetro, diagonal;

            b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            area = b * a;
            perimetro = 2 * (b + a);
            diagonal = Math.Sqrt(Math.Pow(b,2) + Math.Pow(a,2));
            Console.WriteLine("AREA = " + area.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
