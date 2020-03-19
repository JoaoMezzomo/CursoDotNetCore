using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.ClassesEMetodos
{
    class CalculadoraCadeia 
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

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int BuscarMermoria()
        {
            return memoria;
        }
    }

    class CalculadoraComum
    {
        public int Somar(int a, int b) 
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Divisão(int a, int b)
        {
            return a / b;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar() 
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 3);

            Console.WriteLine(resultado);

            Console.WriteLine(calculadoraComum.Subtrair(3, 2));

            var calculadoracadeia = new CalculadoraCadeia();
            calculadoracadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoracadeia.Somar(3).Multiplicar(3).BuscarMermoria();
            Console.WriteLine(resultado);
        }
    }
}
