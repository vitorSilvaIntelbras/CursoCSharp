using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{

        class Carro 
        {
            //3 atributos
            public string Modelo;
            public string Fabricante;
            public int Ano;

            //2 cosntrutores
            public Carro(string modelo, string fabricante, int ano)
            {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }

            public Carro(){

            }
        }
        class Construtores
        {
            public  static void Executar()
            {
                var carro1 = new Carro();
                carro1.Fabricante = "BMW";
                carro1.Modelo = "325i";
                carro1.Ano = 2017;

                System.Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

                var carro2 = new Carro("Ka", "Ford", 2018); 
                System.Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

                var carro3 = new Carro(){
                    Fabricante = "Fiat",
                    Modelo = "Uno",
                    Ano = 2009
                };

                System.Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

            }
        }
}