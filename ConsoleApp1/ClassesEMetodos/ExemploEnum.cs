using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{
        public enum Genero { Acao, Aventura, Animacao, Comedia}

        public class Filme {
            public string Título;
            public Genero GeneroDoFilme;
        }
        class ExemploEnum
        {
            public  static void Executar()
            {
                int id = (int)Genero.Animacao;
                System.Console.WriteLine(id);

                var filmePAraFamilia = new Filme();
                filmePAraFamilia.Título = "Sharknado 17";
                filmePAraFamilia.GeneroDoFilme = Genero.Comedia;

                System.Console.WriteLine("{0} é {1}", filmePAraFamilia.Título, filmePAraFamilia.GeneroDoFilme);
            }
        }
}