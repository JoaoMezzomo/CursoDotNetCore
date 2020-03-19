using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar() 
        {
            //Area de circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é: " +  area);

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);

            byte idade = 45;

            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;

            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;

            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; //Mais usado dos inteiros

            Console.WriteLine("Menor valor " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;

            Console.WriteLine("População brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;

            Console.WriteLine("Menor Lon " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;

            Console.WriteLine("Populaçao Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;

            Console.WriteLine("Preço do computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_00;

            Console.WriteLine("Valor da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;

            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';

            Console.WriteLine("Letra " + letra);

            string texto = "Este é um texto";

            Console.WriteLine("Texto " + texto);
        }
    }
}
