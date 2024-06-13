using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using ConsoleApp1;
using ConsoleApp1.Fundamentos;

namespace ConsoleApp1.Fundamentos
{
    
    class OperadoresUnarios
    {
        public static void Executar()
        {
            int num1 = 3;
            
            var booleano = true;

            Console.WriteLine(-num1);
            Console.WriteLine(!booleano);

        }
    }
}