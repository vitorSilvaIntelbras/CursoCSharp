using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{
        class Membros
        {
            public  static void Executar()
            {
                Pessoas sincrano = new Pessoas();
                sincrano.Nome = "Renato";
                sincrano.Idade = 19;

                sincrano.ApresentarConsole();

                var fulano = new Pessoas();
                fulano.Nome = "Pedro";
                fulano.Idade = 21;

                //esse tipo de apresetação é mais felxivel para o programa
                var apresentacaoDoFulano = fulano.Apresentar();
                System.Console.WriteLine(apresentacaoDoFulano);

            }
        }
}