using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.EstruturasDeControle
{
        class EstruturaForEach
        {
            public  static void Executar()
            {
                var palavra = "Opa";

                foreach (var letra in palavra)
                {
                    System.Console.WriteLine(letra);
                }

                var alunos = new string [] {"Ana", "Vitor", "Vanessa"};
                 foreach (var aluno in alunos)
                {
                    System.Console.WriteLine(aluno);
                }
            }
        }
}