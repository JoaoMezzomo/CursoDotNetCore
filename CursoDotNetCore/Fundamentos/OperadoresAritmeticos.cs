using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar() 
        {
            //Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);

            Console.WriteLine("O preço final é {0}", totalComDesconto);

            //IMC
            double peso = 75;
            double altura = 1.84;
            double imc = peso / Math.Pow(altura, 2);

            Console.WriteLine($"O IMC é {imc}.");

            //Numero par e impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}, ou seja, é um número par", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}, ou seja, é um número impar", impar, impar % 2);
        }
    }
}
