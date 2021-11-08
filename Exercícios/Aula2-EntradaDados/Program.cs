using System;
using System.Globalization;

namespace Aula2_EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {

            // 
            int idade = 25;
            double altura = 1.68;
            char sexo = 'M';
            string nomeDoCliente = "Rafael";
            string sobrenomeDoCliente = "Vieira Suarez";

            //Saida
            Console.WriteLine("Nome cliente: ");
            Console.Write(nomeDoCliente);
            Console.WriteLine("{0} {1}",nomeDoCliente,sobrenomeDoCliente);
            Console.WriteLine("Altura: {0}", altura.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Sexo: {0}", sexo); 
            Console.WriteLine("Idade: {0}", idade);
        }
    }
}
