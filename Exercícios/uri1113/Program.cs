using System;

namespace uri1113
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma
            // mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente.

            // Entrada
            // A entrada contém vários casos de teste. Cada caso contém dois valores inteiros X e Y.A leitura deve 
            // ser encerrada ao ser fornecido valores iguais para X e Y.
            // 5 4
            // Saída
            // Para cada caso de teste imprima “Crescente”, caso os valores tenham sido digitados na ordem crescente,
            // caso contrário imprima a mensagem “Decrescente”.
            // Decrescente

            // Variaveis
            string[] vet;
            int X, Y;

            //Entrada
            vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Descrescente");
                }

                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
        }
    }
}
