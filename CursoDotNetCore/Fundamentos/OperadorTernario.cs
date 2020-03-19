using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDotNetCore.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar() 
        {
            var nota = 7.0;
            bool comportamento = true;
            string resultado = nota >= 7.0 && comportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
