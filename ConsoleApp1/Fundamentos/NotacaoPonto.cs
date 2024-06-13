using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "ola!".ToUpper().Insert(3, "World")
            .Replace("World", "Mundo");
            Console.WriteLine(saudacao);

            string valor = null;
            // o "?" faz que a função seja acessada
            //apenas se funcionar, para nao dar erro
            //ou seja, vazia
            Console.WriteLine(valor?.Length);
            
            
        }
    }
}