using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.Colecoes
{
    class ColecoesSet
    {
        public static void Executar() 
        {
            var livro = new Produto("Game of Thrones", 49.90);

            var carrinho = new HashSet<Produto>();

            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.90),
                new Produto("Livro Harry Potter", 50.0),
                new Produto("Tênis Nike", 349.80)
            };

            carrinho.UnionWith(combo);

            Console.WriteLine(carrinho.Count);

            //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
        }
    }
}
