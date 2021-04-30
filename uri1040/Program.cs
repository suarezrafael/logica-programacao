using System;
using System.Globalization;

namespace uri1040
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            int exame = 0;
            double n1 = double.Parse(input[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(input[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(input[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(input[3], CultureInfo.InvariantCulture);

            double media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media > 5.0 && media < 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                exame = 1;
            }
            else
           if (media > 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }

            if (exame == 1)
            {
                double examNote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media = (media + examNote) / 2;
                if (media < 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                else
                if (media > 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
