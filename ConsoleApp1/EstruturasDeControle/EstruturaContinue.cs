using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.EstruturasDeControle
{
        class EstruturaContinue
        {
            public  static void Executar()
            {
                int intervalo = 30;
                System.Console.WriteLine("");

                for (int i = 1; i <= intervalo; i++)
                {
                    if (i % 2 == 1)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }

            }
        }
}