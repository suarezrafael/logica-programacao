using System;
using System.Globalization;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. 
            //Em seguida, calcule e mostre:
            // a) a área do triângulo retângulo que tem A por base e C por altura.
            // b) a área do círculo de raio C. (pi = 3.14159)
            // c) a área do trapézio que tem A e B por bases e C por altura.
            // d) a área do quadrado que tem lado B.
            // e) a área do retângulo que tem lados A e B.

            // 3.0 4.0 5.2
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //formula triangulo = A * C / 2.0;
            triangulo = A * C / 2.0;

            //formula circulo = 3.14159 * C * C;
            circulo = pi * C * C;

            //formula trapezio = (A + B) / 2.0 * C;
            trapezio = (A + B) / 2.0 * C;

            //formula quadrado = B * B;
            quadrado = B * B;

            //formula retangulo = A * B;
            retangulo = A * B;

            // TRIANGULO: 7.800
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            // CIRCULO: 84.949
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            // TRAPEZIO: 18.200
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            // QUADRADO: 16.000
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            // RETANGULO: 12.000
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
