using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar() 
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            bool comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);

            bool comproTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}", comproTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}
