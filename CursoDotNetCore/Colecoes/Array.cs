using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.Colecoes
{
    class Array
    {
        public static void Executar() 
        {
            string[] alunos = new string[5];
            alunos[0] = "Pedro";
            alunos[1] = "Anderson";
            alunos[2] = "Daniel";
            alunos[3] = "Emanuel";
            alunos[4] = "Roberta";

            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorioNotas = 0;
            double[] notas = { 9.5, 7.8, 4.3, 6.0, 6.0, 10.0 };

            foreach (double nota in notas)
            {
                Console.WriteLine("Nota: {0}", nota);
                somatorioNotas += nota;
            }

            Console.WriteLine("Somatório das notas: {0}", somatorioNotas);

            char[] letras = { 'A', 'B', 'A', 'C', 'A', 'X', 'I' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
