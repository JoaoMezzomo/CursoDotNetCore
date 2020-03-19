using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.Fundamentos
{
    class Conversoes
    {
        public static void Executar() 
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine("Inteiro pra double {0}", quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada {0}", notaTruncada);

            string idadeString = "25";
            int idade = int.Parse(idadeString);
            Console.WriteLine("Idade inteiro {0}", idade);

            int idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Idade inteiro {0}", idadeInteiro);

            string palavra = "dsadsadas";
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Teste Try parse {0}", numero);

        }
    }
}
