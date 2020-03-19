using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.Fundamentos
{
    class Inferencia
    {
        public static void Executar() 
        {
            var nome = "João";
            //nome = 123; não pode
            Console.WriteLine(nome);

            //var idade;
            //idade = 32; não pode iniciar var sem atribuir valor

            int a;
            a = 2;
        }
    }
}
