using System;
using System.Threading;

namespace Aula8OO
{

    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Apelido { get; set; }
        public double SaldoConta { get; set; }

        // contrutor
        public Pessoa()
        {
            Console.WriteLine("Construtor padrão chamado...");
        }
        // construtor com parâmetro Nome
        // Atribui à propriedade "this.Nome" o valor 
        // informado no parâmetro "Nome".
        public Pessoa(string Nome)
        {
            this.Nome = Nome;
            Console.WriteLine("Construtor com parâmetro chamado...");
        }

        // Nome: Correr
        // visibilidade: publico
        // retorno: vazio(void)
        public void Correr()
        {   
            Console.WriteLine(this.Nome);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Correndo...");
                System.Threading.Thread.Sleep(1000);
            }
        }
        public void Descansar()
        {
            Console.WriteLine(this.Nome);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Descansando...");
                System.Threading.Thread.Sleep(1000);
            }
        }

        // paga a conta e recalcula o saldo
        // parametro: valorConta
        public double PagarConta(double valorConta){
            double valor = 0.0;
            valor = valorConta;
            this.SaldoConta = this.SaldoConta - valor;
            return this.SaldoConta;
        }

        public double Depositar(double valor){
            this.SaldoConta = this.SaldoConta + valor;
            return this.SaldoConta;
        }

        internal void ConsultarSaldo()
        {
            Console.WriteLine("Saldo conta: R$ " + this.SaldoConta.ToString("F2"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1° Tipo 2° nome = 3° new Tipo()
            Pessoa individuo1 = new Pessoa();
            individuo1.Id = 1552764095;
            individuo1.Nome = "Yusuke Urameshi";
            individuo1.Apelido = "Baka";
            individuo1.Idade = 15;
            individuo1.DataNascimento = DateTime.Now;

            Pessoa individuo2 = new Pessoa("Mickey");

            individuo2.Id = 123124214;
            individuo2.Apelido = "Rato";
            individuo2.DataNascimento = DateTime.Now;
            individuo2.Idade = 54;

            // executando
            individuo1.Depositar(200.0);
            individuo1.Correr();
            individuo1.PagarConta(100.0);
            individuo1.Descansar();
            individuo1.ConsultarSaldo();
            
            Console.WriteLine("------");
            individuo2.Depositar(300.0);
            individuo2.Correr();
            individuo2.PagarConta(200.0);
            individuo2.Descansar();
            individuo2.ConsultarSaldo();

        }
    }
}
