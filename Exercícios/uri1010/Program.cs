using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca1,numeroPecas1, codPeca2, numeroPecas2;
            double total, valorUnitarioPeca1,valorUnitarioPeca2;

            string[] valores = Console.ReadLine().Split(" ");

            codPeca1 = int.Parse(valores[0]);
            numeroPecas1 = int.Parse(valores[1]);
            valorUnitarioPeca1 = double.Parse(valores[2],CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(" ");

            codPeca2 = int.Parse(valores[0]);
            numeroPecas2 = int.Parse(valores[1]);
            valorUnitarioPeca2 = double.Parse(valores[2],CultureInfo.InvariantCulture);

            total = valorUnitarioPeca1 * numeroPecas1 + valorUnitarioPeca2 * numeroPecas2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",CultureInfo.InvariantCulture) );
        }
    }
}
