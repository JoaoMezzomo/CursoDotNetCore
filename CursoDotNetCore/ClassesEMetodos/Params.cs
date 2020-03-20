using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas) 
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }

        public static void Executar() 
        {
            Recepcionar("Maria", "João", "Jennifer", "Pedro", "Maurício");
        }
    }
}
