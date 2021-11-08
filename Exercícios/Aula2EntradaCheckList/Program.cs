using System;

namespace Aula2EntradaCheckList
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";

            frase = Console.ReadLine();
            string[] vetor = frase.Split(' ');

            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);

        }
    }
}
