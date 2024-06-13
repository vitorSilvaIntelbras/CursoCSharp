using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.EstruturasDeControle
{
        class EstruturaWhile
        {
            public  static void Executar()
            {
               int palpite = 0;
               Random random = new Random();
               

               int numeroSecreto = random.Next(1,16);
               bool numeroEncontrado = false;
               int  tentativasRestantes = 5;
               int tentativas = 0;


               while (tentativasRestantes > 0 && !numeroEncontrado) 
               {
                    System.Console.WriteLine("Insira seu palpite: ");
                    string entrada = Console.ReadLine();
                    int.TryParse(entrada, out palpite);

                    tentativas++;
                    tentativasRestantes--; 

                    if (numeroSecreto == palpite)
                    {
                        numeroEncontrado = true;
                        var corAnterior = Console.BackgroundColor;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Número encontrado em {0} tentativas", tentativas);

                        Console.BackgroundColor = corAnterior;
                    }else if (palpite >  numeroSecreto)
                    {
                        System.Console.WriteLine("O número e menor, tente novamente");
                        System.Console.WriteLine("Tentativas restante {0}", tentativasRestantes);
                    }else
                    {
                        System.Console.WriteLine("O número é maior ");
                        System.Console.WriteLine("Tentativas restante {0}", tentativasRestantes);
                    }
               }
            }
        }
}