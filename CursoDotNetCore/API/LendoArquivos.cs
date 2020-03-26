using System;
using System.IO;

namespace CursoDotNetCore.API
{
    class LendoArquivos
    {
        public static void Executar() 
        {
            var path = @"~\lendo_arquivos.txt".ParseHome();

            //using (StreamWriter sw = File.AppendText(path))
            //{
            //    sw.WriteLine("Produto;Preco;Qtde");
            //    sw.WriteLine("Caneta;3.50;4");
            //    sw.WriteLine("Borracha;3.50;3");
            //    sw.WriteLine("Caderno;10.99;10");
            //    sw.WriteLine("Lapis;3.0;3");
            //}

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
