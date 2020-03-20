using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar() 
        {
            // Acessar variável 'a' dentro do método Executar.

            DesafioAtributo classe = new DesafioAtributo();

            Console.WriteLine("Valor da variável 'a' da classe: {0}", classe.a);
        }
    }
}
