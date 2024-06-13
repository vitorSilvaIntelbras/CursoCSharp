using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{
        public class CalculadoraEstatica
        {
            //Método de Instância
            public  int Somar(int a, int b)
            {
                return a + b;
            }

            //Método de Classe Ou Método Estatico
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }
        class MetodosEstaticos
        {
            public  static void Executar()
            {
                var resultado = CalculadoraEstatica.Multiplicar(2, 2);
                System.Console.WriteLine(resultado);

                CalculadoraEstatica calc = new CalculadoraEstatica();
                System.Console.WriteLine(calc.Somar(6,9));
            }
        }
}