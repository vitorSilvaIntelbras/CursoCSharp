using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using System.Text;
//using System.Globalizaton (faz com que use o separador indiferente de numeros)

namespace ConsoleApp1.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            //usando o system.globalization
            Console.Write("Digite seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo
            .InvariantCulture);
            //indentifica separação com qualquer [. ,]

            Console.WriteLine($"Você, {nome}, tem {idade} anos de idade, e recebe {salario} reais");

            
        }
    }
}