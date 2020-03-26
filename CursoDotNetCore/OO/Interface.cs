using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.OO
{
    interface OperacaoBinaria 
    {
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria 
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria 
    {
        public int Operacao(int a, int b) 
        {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria 
    {
        public int Operacao(int a, int b) 
        {
            return a * b;
        }
    }

    class Calculadora 
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b) 
        {
            string resultado = "";

            foreach (var item in operacoes)
            {
                resultado += $"Usando {item.GetType().Name} = {item.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }

    class Interface
    {
        public static void Executar() 
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.ExecutarOperacoes(10, 50));
        }
    }
}
