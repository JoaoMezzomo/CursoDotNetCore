﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada) 
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;

            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() 
        {

        }

        public string GetMarca() 
        {
            return Marca;
        }

        public void SetMarca(string marca) 
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public int GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(int cilindrada)
        {
            if (cilindrada > 0)
            {
                Cilindrada = cilindrada;
            }
        }
    }

    class GetSet
    {
        public static void Executar() 
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZK-GR", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());
            Console.WriteLine();
            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());
        }
    }
}
