using System;
using System.Globalization;

namespace DemoEntradaDados1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char c1 = char.Parse(Console.ReadLine());
            double d1 = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(c1);
            Console.WriteLine(d1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
