﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.Colecoes
{
    class Produto 
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) 
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }

    class ColecoesList
    {
        public static void Executar() 
        {
            var livro = new Produto("Game of Thrones", 49.90);

            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.90),
                new Produto("Livro Harry Potter", 50.0),
                new Produto("Tênis Nike", 349.80)
            };

            carrinho.AddRange(combo);

            Console.WriteLine(carrinho.Count);

            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
        }
    }
}
