using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.EstruturasDeControle
{
        class EstruturaIF
        {
            public static void Executar()
            {
                bool bomComportamento = false;
                string entrada;
                Console.WriteLine("Digite a nota do aluno: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double nota);

                System.Console.WriteLine("Possui um bom coportamento? (S/N)");
                entrada = Console.ReadLine();

                // if(entrada  == "S" || entrada == "s")
                // {
                //     bomComportamento = true;
                // }
                //bomComportamento = entrada == "s" || entrada =="S";
                bomComportamento = entrada.ToLower() == "s";

                if(nota >= 9.0 && bomComportamento)
                {
                    System.Console.WriteLine("Quadro de honra!");
                }else{
                    System.Console.WriteLine("Fora do quadro de honra!");
                }
                
            }
        }
}