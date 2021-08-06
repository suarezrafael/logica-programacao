using System;
using System.Globalization;

namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total 
            // de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor 
            // ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber 
            // no final do mês, com duas casas decimais.
            // JOAO
            //500.00
            //1230.30
            //TOTAL = R$ 684.54
            string nomeVendedor;
            double salarioBaseVendedor,totalVendasMes,totalComComissao;

            // entrada
            // nomeVendedor
            // salarioBaseVendedor
            // totalVendasMes
            nomeVendedor = Console.ReadLine();
            salarioBaseVendedor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            totalVendasMes = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            // processamento
            // totalComComissao = salarioBase + (totalVendas * 15%)
            totalComComissao = salarioBaseVendedor + (totalVendasMes * 15 / 100 );
           
            // saida
            // TOTAL = totalComComissao
            Console.WriteLine("TOTAL = R$ " + totalComComissao.ToString("F2",CultureInfo.InvariantCulture)); 
        }
    }
}
