using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.OO
{
    sealed class SemFilho 
    {
        public double ValorDeFortuna() 
        {
            return 1_407_056.65;
        }
    }

    class Avo 
    {
        public virtual bool HonrarNomeFamilia() 
        {
            return false;
        }
    }

    class Pai : Avo 
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Sealed
    {
        public static void Executar() 
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDeFortuna());

            
        }
    }
}
