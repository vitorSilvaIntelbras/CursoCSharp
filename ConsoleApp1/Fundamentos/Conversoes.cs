using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ConsoleApp1.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            //nao há perda de informação
            double quebrado = inteiro;
            System.Console.WriteLine(quebrado);

            //double nota = 9.7;
            //nao é possivel converter implicitamente
            //int notaTruncada = nota;

            //conversão explcita (CAST)
            double nota = 9.7;
            int notaTruncada = (int) nota;
            System.Console.WriteLine("Nota truncada {0}", notaTruncada);


            //string para int
            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);
            
            idadeInteiro = Convert.ToInt32(idadeString);
            System.Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.WriteLine("Digite um numero");
            string palavra = Console.ReadLine();
            int numero;
            //pegar o que tem na palavra e jogar dentro de numero
            int.TryParse(palavra, out numero);
            Console.WriteLine("Numero inserido {0}", numero);
            
            Console.WriteLine("Digite outro numero");            
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado {0}", numero2);


        }
    }
}