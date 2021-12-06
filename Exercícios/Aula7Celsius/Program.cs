using System;
using System.Globalization;

namespace Aula7Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // Fazer um programa para ler uma temperatura em Celsius e mostrar o
            // equivalente em Fahrenheit. Perguntar se o usuário deseja repetir (s/n).
            // Caso o usuário digite "s", repetir o programa.
            string repetir;
            double temperaturaCelsius;
            double temperaturaFahrenheit;
            
            do{
                Console.Write("Digite a temperatura em Celsius: ");
                temperaturaCelsius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                // (0 °C × 9/5) + 32 = 32 °F
                temperaturaFahrenheit = (temperaturaCelsius * 9.0/5.0) + 32.0;

                Console.WriteLine("Equivalente em Fahrenheit: " + temperaturaFahrenheit.ToString("F1"));
                Console.WriteLine("Deseja repetir (s/n)? ");
                repetir = Console.ReadLine();

            } while(repetir == "s");

        }
    }
}
