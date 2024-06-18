using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp1.ClassesEMetodos
{
    public class Moto{
        private string Marca;
        private string Modelo;
        private uint Cilindrada;
        //o UINT não possui sinal

        //aplicar validações proprias e especificas
        //Get : le o valor do atributo
        //Set : altera o valor do atributo

        //construtor para receber o parametros
        public Moto(string marca, string modelo, uint cilindrada){
            // Modelo = modelo;
            // Marca = marca;
            // Cilindrada = cilindrada;

            SetMArca(marca);
            SetCilindrada(cilindrada);
            SetModelo(modelo);

        }

        public Moto() {

        }

        public string GetMarca () {
            return Marca;
        }

        public void SetMArca(string marca){
            Marca = marca;
        }

        public string GetModelo () {
            return Modelo;
        }

        public void SetModelo(string modelo){
            Modelo = modelo;
        }

        public uint GetCilindrada () {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada){
            if (cilindrada > 0 && cilindrada <= 1300){
                Cilindrada = cilindrada;
            }
            //usar valor absoluto 
            //===Cilindrada = Math.Abs(cilindrada)===

            //para nao ser negativa
        }
    }

    
    
    class GetSet
        {
            public  static void Executar()
            {
                var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
                System.Console.WriteLine(moto1.GetMarca());
                System.Console.WriteLine(moto1.GetModelo());
                System.Console.WriteLine(moto1.GetCilindrada());

                var moto2 = new Moto("Honda", "CG-Titan", 160);
                System.Console.WriteLine(moto2.GetMarca());
                System.Console.WriteLine(moto2.GetModelo());
                System.Console.WriteLine(moto2.GetCilindrada());
            }
        }
}