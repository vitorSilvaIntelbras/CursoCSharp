using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{
    public class Cliente{
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento){
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento(){
            return String.Format("{0}/{1}/{2}", 
            Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class Readonly
        {
            public static void Executar()
            {
                var novoCliente = new Cliente("Ana Silva", 
                new DateTime(1987, 5, 22));

                var novoCliente2 = new Cliente("Vitor", new DateTime(2005, 3, 7));

                System.Console.WriteLine(novoCliente.Nome);
                System.Console.WriteLine(novoCliente.GetDataDeNascimento());

                // novoCliente.Nascimento = new DateTime(2020, 10, 10);
            }
        }
}