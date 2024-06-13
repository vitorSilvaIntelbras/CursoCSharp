using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using ConsoleApp1;
using ConsoleApp1.Fundamentos;

namespace ConsoleApp1.Fundamentos
{
    
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaCorte = 7.0;
            Console.WriteLine("Nota inválida? {0}", nota < 10.0);
            Console.WriteLine("Nota inválida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Pode melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou de ano? {0}", nota >= notaCorte);

        }
    }
}