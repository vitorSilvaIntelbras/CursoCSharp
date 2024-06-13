using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{
        class Pessoas
        {
            //faz com que os aributos pertençam também à classe "Pessoas"
            public string Nome;
            public int Idade;

            //3 comportamentos
            public string Apresentar()
            {
                return string.Format($"Olá me chamo {Nome} e tenho {Idade} anos");
            }

            public void ApresentarConsole()
            {
                System.Console.WriteLine(Apresentar());
            }

            public void Zerar()
            {
                Nome = "";
                Idade = 0;
            }

             
                
            
        }
}