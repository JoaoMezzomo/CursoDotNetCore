using System;
using System.Collections;
using System.Text;

namespace CursoDotNetCore.Colecoes
{
    class ColecaoStack
    {
        public static void Executar() 
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push('b');
            pilha.Push(true);
            pilha.Push(3.78);

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} {item.GetType()}");
            }

            Console.WriteLine($"Pop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} {item.GetType()}");
            }

            Console.WriteLine($"Peek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);

        }
    }
}
