using System;

namespace TesteVariaveis5
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;

            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();
            Console.WriteLine(frase);

            string[] vetor = frase.Split(" ");
            string palavra1 = vetor[0];
            string palavra2 = vetor[1];
            string palavra3 = vetor[2];

            Console.WriteLine(palavra1);
            Console.WriteLine(palavra2);
            Console.WriteLine(palavra3);
        }
    }
}
