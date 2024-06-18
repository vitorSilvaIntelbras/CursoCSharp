using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{
    public class CarroOpcional {
        double desconto = 0.1;
        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set{
                nome = value;
            }
        }
        //propriedades autoimplementada
        public double Preco {get; set;}

        // //somente leitura
        public double PrecoComDesconto{
            get => Preco - (desconto * Preco);
            }
            
        
        
        public CarroOpcional(){

        }
        
         public CarroOpcional(string nome, double preco){
            Nome = nome;
            Preco = preco;
        }

    }
    class Propriedades
        {
            public  static void Executar()
            {
                var op1 = new CarroOpcional("Ar Condicionado", 3499.99);
                System.Console.WriteLine(op1.PrecoComDesconto);

                var op2 = new CarroOpcional("Direção Elétrica", 2789.99);
                System.Console.WriteLine(op2.PrecoComDesconto);

                System.Console.WriteLine(op2.Nome);
                System.Console.WriteLine(op2.Preco);
                System.Console.WriteLine(op2.PrecoComDesconto);



            }
        }
}