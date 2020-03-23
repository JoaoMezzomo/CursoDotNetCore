using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.ClassesEMetodos
{
    class ExemploEnum
    {
        public enum Genero
        {
            Acao,
            Aventura,
            Terror,
            Animacao,
            Comedia
        };

        public class Filme 
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }

        public static void Executar() 
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Jumanji";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}
