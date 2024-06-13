using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.EstruturasDeControle
{
        class EstruturaFor
        {
            public  static void Executar()
            {

                double somatorio = 0;
                string entrada;

                System.Console.WriteLine("Informe o tamanho da turma: ");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out int tamanhoTurma);

                for (int i = 1; i <= tamanhoTurma; i++)
                {
                    System.Console.WriteLine("Informe a nota do aluno {0}", i);
                    entrada = Console.ReadLine();
                    double.TryParse(entrada, out double notaAtual);
                    somatorio += notaAtual;
                }
                //se . . . divida ou entao bote 0
                double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0 ;
                System.Console.WriteLine("Media da turma {0}", media);

            }
        }
}