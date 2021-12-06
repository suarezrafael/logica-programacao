using System;
using System.Globalization;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de variáveis
            string nomeCompleto = "";
            int qtdQuartos = 0;
            double precoInternet;

            // entrada de dados
            Console.Write("Informe seu nome completo:");
            nomeCompleto = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa?");
            qtdQuartos = int.Parse(Console.ReadLine());
            
            Console.Write("Informe o preço da sua internet:");
            precoInternet = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Informe último nome, idade e altura:");
            string[] vect = Console.ReadLine().Split(" ");
            string ultimoNome = vect[0];
            int idade = int.Parse(vect[1]);
            double altura = double.Parse(vect[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoInternet.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}
