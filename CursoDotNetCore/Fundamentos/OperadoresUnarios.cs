using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar() 
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var boolean = true;

            Console.WriteLine(-valorNegativo);

            Console.WriteLine(!boolean);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
