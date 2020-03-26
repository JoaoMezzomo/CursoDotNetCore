using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoDotNetCore.API
{
    class ExemploDirectoryInfo
    {
        public static void Executar() 
        {
            var diretorio = "~".ParseHome();

            var dirInfo = new DirectoryInfo(diretorio);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("========= Arquivos ============");

            var arquivos = dirInfo.GetFiles();

            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("========= Pasta ============");

            var pastas = dirInfo.GetDirectories();

            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);

            
        }
    }
}
