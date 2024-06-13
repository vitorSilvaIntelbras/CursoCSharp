using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Text;
using ConsoleApp1;
using ConsoleApp1.Fundamentos;

namespace ConsoleApp1.Fundamentos
{
    
    class OperadoresLogicos01
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou tv de 50? {0}", comprouTV50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);

            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou sorvete? {0}", comprouTV32);
            //inversor de sinal lógico "!"
            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);
        }
    }
}