using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoDotNetCore.TopicosAvancados
{
    public class Aluno 
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1
    {
        public static void Executar() 
        {
            var alunos = new List<Aluno>
            {
                new Aluno(){ Nome = "Pedro", Idade = 18, Nota = 3},
                new Aluno(){ Nome = "Ana", Idade = 19, Nota = 5},
                new Aluno(){ Nome = "Paulo", Idade = 17, Nota = 8},
                new Aluno(){ Nome = "Roberto", Idade = 18, Nota = 10},
                new Aluno(){ Nome = "Ana", Idade = 18, Nota = 5},
                new Aluno(){ Nome = "João", Idade = 20, Nota = 8},
                new Aluno(){ Nome = "William", Idade = 18, Nota = 9},
            };

            Console.WriteLine("== Aprovados ====");

            var aprovados = alunos.Where(a => a.Nota >= 6).OrderBy(a => a.Nota);

            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nota + " - " + aluno.Nome);
            }
        }
    }
}
