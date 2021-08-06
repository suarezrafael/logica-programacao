using System;

namespace uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
              double[] banknotes = {100.00,50.00,20.00,10.00,5.00,2.00};
            int[] qtdNotes={0,0,0,0,0,0};
            double[] moedas={1.00,0.50,0.25,0.10,0.05,0.01};
            int[] qtdMoedas={0,0,0,0,0,0};
            double input =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            

            //Notas
            if(input>=banknotes[0]){
                qtdNotes[0] =(int)Math.Floor(input/100);
                input= input % 100;
                
            }
            if(input>=banknotes[1]){
                qtdNotes[1] =(int)Math.Floor(input/50)                                            ;
                input= input % 50;
                
            }
            if(input>=banknotes[2]){
                qtdNotes[2] =(int)Math.Floor(input/20);
                input= input % 20;
                
            }
            if(input>=banknotes[3]){
                qtdNotes[3] =(int)Math.Floor(input/10);
                input= input % 10;
                
            }
            if(input>=banknotes[4]){
                qtdNotes[4] =(int)Math.Floor(input/5);
                input= input % 5;
                
            }
            if(input>=banknotes[5]){
                qtdNotes[5] =(int)Math.Floor(input/2);
                input= input % 2;
                
            }
            //Moedas
            if(input>=moedas[0]){//1.00
                qtdMoedas[0] =(int)Math.Floor(input/moedas[0]);
                input= input % moedas[0];  
            }if(input>=moedas[1]){//0.50
                qtdMoedas[1] =(int)Math.Floor(input/moedas[1]);
                input= input % moedas[1];  
            }
            if(input>=moedas[2]){//0.25
                qtdMoedas[2] =(int)Math.Floor(input/moedas[2]);
                input= input % moedas[2];  
            }
            if(input>=moedas[3]){//0.10
                qtdMoedas[3] =(int)Math.Floor(input/moedas[3]);
                input= input % moedas[3];  
            }
            if(input>=moedas[4]){//0.05
                qtdMoedas[4] =(int)Math.Floor(input/moedas[4]);
                input= input % moedas[4];  
            }

            ///Arredonda o troco pra 5 centavos caso faltar 4 centavos
            // string quatro=input.ToString("F2",CultureInfo.InvariantCulture);
            // if(quatro == "0.04"){
            //     qtdMoedas[4]+= 1;
            //     input =0;
            // }
            
            if(input>=moedas[5]){//0.01
                qtdMoedas[5] =(int)Math.Floor(input/moedas[5]);
                input= input % moedas[5];  
            }

            
                Console.WriteLine("NOTAS:");
                Console.WriteLine(qtdNotes[0]+" nota(s) de R$ 100.00");
                Console.WriteLine(qtdNotes[1]+" nota(s) de R$ 50.00");
                Console.WriteLine(qtdNotes[2]+" nota(s) de R$ 20.00");
                Console.WriteLine(qtdNotes[3]+" nota(s) de R$ 10.00");
                Console.WriteLine(qtdNotes[4]+" nota(s) de R$ 5.00");
                Console.WriteLine(qtdNotes[5]+" nota(s) de R$ 2.00");
                Console.WriteLine("MOEDAS:");
                Console.WriteLine(qtdMoedas[0]+" moeda(s) de R$ 1.00");
                Console.WriteLine(qtdMoedas[1]+" moeda(s) de R$ 0.50");
                Console.WriteLine(qtdMoedas[2]+" moeda(s) de R$ 0.25");
                Console.WriteLine(qtdMoedas[3]+" moeda(s) de R$ 0.10");
                Console.WriteLine(qtdMoedas[4]+" moeda(s) de R$ 0.05");
                Console.WriteLine(qtdMoedas[5]+" moeda(s) de R$ 0.01");
        }
    }
}
