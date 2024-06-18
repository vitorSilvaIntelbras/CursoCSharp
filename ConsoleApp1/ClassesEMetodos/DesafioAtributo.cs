using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{
        public class DesafioAtributo
        {

            int a = 10;
            //atributo de instancia
            public  static void Executar()
            //metodo que opertence a classe não consegue acessar atributo de instancia
            {
                DesafioAtributo desafio = new DesafioAtributo(); 
                System.Console.WriteLine(desafio.a);
                
                
            }
        }
}