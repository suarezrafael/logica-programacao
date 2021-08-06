using System;
using System.Globalization;

namespace ExercicioResolvidoAula21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler duas notas que um aluno obteve no primeiro e segundo 
            // semestre de uma disciplina. Em seguida, mostrar a nota final que o aluno obteve 
            // e junto um texto explicativo. Caso a nota final seja  inferior a 60.00, mostrar 
            // a mensagem "REPROVADO". Todos os valores deve  ter uma casa decimal.
            // Entrada : 45.5 34.0
            // 31.3 23.5
            // Saida: NOTA FINAL = 76.8 57.5

            double n1, n2, nFinal;

            // Entrada
            n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Processamento
            nFinal = n1 + n2;
            
            // Saida
            Console.WriteLine("NOTA FINAL = " + nFinal.ToString("F1",CultureInfo.InvariantCulture));

            if( nFinal < 60.00 ){
                Console.WriteLine("REPROVADO");
            }

        }
    }
}
