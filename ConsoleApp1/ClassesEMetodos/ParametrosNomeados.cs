using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{
    class ParametrosNomeados
        {

            public static void Formatar(int dia, int mes, int ano){
                System.Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
            }
            public  static void Executar()
            {
                Formatar(mes: 1, dia: 6, ano: 2024);

            }
        }
}