using System;
using System.Globalization;

namespace Raio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*             A fórmula para calcular a área de uma circunferência é: area = π . raio2. 
            Considerando para este problema que π = 3.14159:
            - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.
            Entrada
            A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.
            Exemplos de Entrada	Exemplos de Saída
            2.00 A=12.5664
            Saída */
            double pi, area, raio;

            pi = 3.14159;
            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Raio informado: {0:f4}", raio);
            area = pi * Math.Pow(raio,2);
            Console.WriteLine("A={0:f4}",area);
            string msg = "tchau";
            Console.WriteLine("{0}",msg);
        }
    }
}
