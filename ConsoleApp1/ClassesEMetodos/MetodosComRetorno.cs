using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{


        class CalculadoraComum {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Substrair(int a, int b)
            {
                return a - b;
            }

            public int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }

        public class CalculadoraCadeia
        {
            int memoria;

            public CalculadoraCadeia Somar(int a)
            {
                memoria += a;
                return this;
            }

            public CalculadoraCadeia Multiplicar(int a)
            {
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Imprimir()
            {
                System.Console.WriteLine(memoria);
                return this;
            }

            public CalculadoraCadeia Limpar()
            {
                memoria = 0;
                return this;
            }

            public int Resultado()
            {
                return memoria;
            }
        }


        class MeotodsComRetorno
        {
            public  static void Executar()
            {
                //instanciar a CalculadoraComum dentro do metodo
                var CalculadoraComum = new CalculadoraComum();
                var resultado = CalculadoraComum.Somar(5, 5);
                System.Console.WriteLine(resultado);
                System.Console.WriteLine(CalculadoraComum.Substrair(123,36));
                System.Console.WriteLine(CalculadoraComum.Multiplicar(13,6));
                
                //encadeando sentença sentenças de codigo com uma unica chamada em cadeia
                var calculadoraCadeia = new CalculadoraCadeia();
                calculadoraCadeia.Somar(3).Multiplicar(9).Imprimir().Limpar().Imprimir();

                resultado = calculadoraCadeia.Somar(3).Multiplicar(9).Resultado();
                System.Console.WriteLine(resultado);
            }
        }
}