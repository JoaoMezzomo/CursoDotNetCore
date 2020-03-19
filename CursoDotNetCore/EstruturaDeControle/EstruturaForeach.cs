using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.EstruturaDeControle
{
    class EstruturaForeach
    {
        public static void Executar() 
        {
            var palavra = "Olá!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            string[] alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
