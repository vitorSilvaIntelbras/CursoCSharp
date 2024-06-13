using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.EstruturasDeControle
{
        class EstruturaSwitch
        {
            public static void Executar()
            {
                Console.WriteLine("Avalie meu atendimento de 1 até 5: ");
                int.TryParse(Console.ReadLine(), out int nota);

                switch(nota)
                {
                    case 0:
                        Console.WriteLine("Péssimo");
                        break;

                    case 1:
                    case 2:
                        Console.WriteLine("Ruim");
                        break;

                    case 3:
                        Console.WriteLine("Regular");
                        break;

                    case 4:
                        Console.WriteLine("Boa");
                        break;

                    case 5:
                        Console.WriteLine("Excelente");
                        break;

                }
                System.Console.WriteLine("Fim");
            }
        }
}