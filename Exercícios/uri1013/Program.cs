using System;

namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {

            // Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:
            // Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.
            // Entrada
            // O arquivo de entrada contém três valores inteiros.
            // Saída
            // Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

            // variaveis
            int a, b, c, maiorAB, maiorABC;
            string[] vetor;

            // entrada de dados
            vetor = Console.ReadLine().Split(' ');
            
            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);
            
            // processamento
            maiorAB = (a + b + Math.Abs( a - b ) ) / 2;

            maiorABC  = ( maiorAB + c + Math.Abs(maiorAB - c) ) / 2;

            // saida de dados
            Console.WriteLine(maiorABC + " eh o maior");

        }
    }
}
