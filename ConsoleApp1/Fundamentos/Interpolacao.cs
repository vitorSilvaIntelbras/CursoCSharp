using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O {0} da marca {1} custa cerca de \n {2} reais.",
             nome, marca, preco);

            Console.WriteLine($"O {nome} da marca {marca} custa cerca de \n {preco} reais.");

            Console.WriteLine($"1 + 1 é igual a: {1+1}!");

            


        }
    }
}