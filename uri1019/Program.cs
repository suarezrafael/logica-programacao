using System;

namespace uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, horas, minutos, segundos, resto;

            valor = int.Parse(Console.ReadLine());

            // hora 60 minutos, 3600 segundos
            horas = valor / 3600;
            resto =  valor % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas+":"+minutos+":"+segundos);

// Exemplo de Entrada	Exemplo de Saída
// 556
// 0:9:16
// 1
// 0:0:1
// 140153
// 38:55:53

        }
    }
}
