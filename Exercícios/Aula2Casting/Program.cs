using System;
using System.Globalization;

namespace Aula2Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double resultado;
            a = 5;
            b = 2;
            resultado = (double) a / b;
            Console.WriteLine(resultado.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
