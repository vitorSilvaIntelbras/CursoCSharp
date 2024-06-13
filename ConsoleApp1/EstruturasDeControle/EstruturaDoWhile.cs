using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.EstruturasDeControle
{
        class EstruturaDoWhile
        {
            public  static void Executar()
            {
                string  entrada;

                do 
                {
                    System.Console.WriteLine("Digite seu nome: ");
                    entrada = Console.ReadLine();

                    System.Console.WriteLine("Seja bem vindo {0}", entrada);
                    System.Console.WriteLine("Deseja Continuar? (S/N) ");
                    entrada = Console.ReadLine();

                }while (entrada.ToLower() == "s");
            }
        }
}