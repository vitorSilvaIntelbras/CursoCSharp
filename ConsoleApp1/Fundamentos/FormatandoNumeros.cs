using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            //colocando com apenas uma casa decimal(arrodondando)
            Console.WriteLine(valor.ToString("F1"));
            //Tranforma em valor monetário
            Console.WriteLine(valor.ToString("C"));
            //trasnforma em percentual
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.######"));

            CultureInfo cultura = new CultureInfo("pt-BR");

            //em dinheiro sem casa decimal,  e com o padrão cultura ptbr
            Console.WriteLine(valor.ToString("C0", cultura));

            int numero = 256;
            //quero copletar o numerom com zeros
            Console.WriteLine(numero.ToString("D10"));
        }
    }
}