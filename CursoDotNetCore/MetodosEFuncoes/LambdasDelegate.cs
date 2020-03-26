using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);

    class LambdasDelegate
    {
        public static void Executar() 
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(2, 5));
            Console.WriteLine(sub(3, 3));
            Console.WriteLine(mult(32131232132, 43242342));
            
        }
    }
}
