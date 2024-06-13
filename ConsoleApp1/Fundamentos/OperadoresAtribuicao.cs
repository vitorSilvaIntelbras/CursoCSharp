using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ConsoleApp1.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 += 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;
            Console.WriteLine(num1);

            //nao se procupe com o código agora
            //atribuição por referência
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";
            Console.WriteLine(c.nome);



        }
    }
}