using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.EstruturasDeControle
{
        class EstruturaBreak
        {
            public  static void Executar()
            {
                Random random = new Random();
                int numero = random.Next(1,51);

                System.Console.WriteLine("O número que queremos é {0}", numero);

                for (int i = 1; i <= 51; i++)
                {
                    System.Console.WriteLine("{0} é o número que queremos? ", i);
                    if (i == numero)
                    {
                        System.Console.WriteLine("SIM!");
                        break;
                    }else
                    {
                        System.Console.WriteLine("NÃO!");
                    }
                }
                System.Console.WriteLine("FIM!");

            }
        }
}