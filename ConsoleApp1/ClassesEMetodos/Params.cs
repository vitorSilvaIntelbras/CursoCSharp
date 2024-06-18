using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{
    class Params
        {
            public static void Recepcionar(params string[] pessoas){
                foreach (var pessoa in pessoas){
                    Console.WriteLine("Olá {0}", pessoa); 
                }
            }
            
            public static void Executar()
            {
                Recepcionar("Vitor", "Pedro", "Joao");

            }
        }
}