using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using ConsoleApp1;
using ConsoleApp1.Fundamentos;

namespace ConsoleApp1.Fundamentos
{
    
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            bool bomComportamento = true;
            //"?" como se fosse um SE, ":" como se fosse SENÂO
            string resultado = nota >= 7.0  && bomComportamento
            ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);



        }
    }
}