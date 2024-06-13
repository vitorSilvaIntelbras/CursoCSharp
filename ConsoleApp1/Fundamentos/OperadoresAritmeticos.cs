using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1.Fundamentos
{
    /// <summary>
    ///
    /// </summary>
    class OperadoresAritmeticos
    {
        public static void Executar()
        {//preço com desconto
        var preco = 1000.0;
            var imposto = 349;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalDesconto = total - total * desconto;
            System.Console.WriteLine("O preço final é de {0}", totalDesconto);            

            //IMC
            double peso = 97.6;
            double altura = 1.90;
            //elevar altura ao qudrado
            double imc = peso /Math.Pow(altura, 2);
            System.Console.WriteLine("IMC: {0}", imc);


            //PAR/IMPAR
            int par = 24;
            int impar = 25;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}