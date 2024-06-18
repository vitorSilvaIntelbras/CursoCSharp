using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{
        public class Produto
        {
            public string Nome;
            public Double Preco;
            public double Desconto = 0.1;
            //se fosse public static double Desconto
            //viraria um atributo de classe, e nao de instancia
            //"Produto.Desconto = 0.5  (desconto aplicados para todos os produtos)"

            public Produto( string nome, double preco, double desconto){
                Nome = nome;
                Preco = preco;
                Desconto = desconto;
                 
            }

            public double CalcularDesconto(){
                return Preco - Preco * Desconto;
            }
        }
        public class AtributosEstaticos
        {
            public static void Executar()
            {
                var produto1 = new Produto("Caneta", 3.2, 0.1);
                var produto2 = new Produto("Borracha", 5.2, 0.15);

                System.Console.WriteLine("Preço com desconto {0}", produto1.CalcularDesconto());
                System.Console.WriteLine("Preço com desconto {0}", produto2.CalcularDesconto());
                

            }
            
        }
}