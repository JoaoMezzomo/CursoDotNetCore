using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um instagram";

        //Herança
        protected string CorDoOlho = "Verde";

        //Mesmo projeto (assembly)
        internal ulong NumeroCelular = 55519904567;

        //Heranças ou mesmo projeto
        protected internal string JeitoDefalar = "Uso muitas girias";

        // Mesma classe ou herança ou mesmo projeto
        private protected string SegredoFamilia = "Bla bla";

        //Private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() 
        {
            Console.WriteLine("SubCelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDefalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
