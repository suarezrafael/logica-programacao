using System;
using System.Diagnostics;

namespace ExercicioResolvidoParaAula21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia do processo de inicialização de programa
            ProcessStartInfo pro = new ProcessStartInfo();
            // definindo o nome do programa
            pro.FileName = "cmd.exe";
            // Inicia um novo processo
            Process processo = new Process();
            processo.StartInfo = pro;
            // chamada o metodo start para iniciar o processo
            processo.Start();

            for (int x = 1; x <= 1; x++)
            {
                // executamos o bloco de notas
                Process.Start("notepad.exe");
            }

        }
    }
}
