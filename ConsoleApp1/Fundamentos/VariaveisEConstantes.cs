using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Fundamentos
{
    /// <summary>
    ///
    /// </summary>
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5f;
            const double PI = 3.14;
            raio = 5.5;
            // PI = 23131;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo" + estaChovendo);

            byte idade= 45;
            Console.WriteLine("Idade é " + idade);

            //aceita byte valores negativos
            //MinValue mostra o menor valor que é -127
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols é " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salário é " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("O menor valor dos inteiros é " + menorValorInt);

            uint populacao = 203_344_341;
            Console.WriteLine("A população é " + populacao);

            long menorLong = long.MinValue;
            Console.WriteLine("Menor long   é " + menorLong);

            long populacaoMundial = 7_934_127_990;
            Console.WriteLine("Menor long   é " + populacaoMundial);

            float precoComputador = 13123f;
            Console.WriteLine("O preço do comp é " + precoComputador);

            double valorDaApple = 1_000_000_000_000.00;
            Console.WriteLine("O valor da Apple é " + valorDaApple);

            decimal distanciaEntreEstrelas = 6301623123890619380;
            Console.WriteLine("Distâncias extremas " + distanciaEntreEstrelas);

            char letra = 'b';
            System.Console.WriteLine("A letra é" + letra);

            string texto = "Seja bem vindo ao C#";
            Console.WriteLine(texto);


            



        }
    }
}