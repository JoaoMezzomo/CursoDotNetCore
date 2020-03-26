using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoDotNetCore.API
{
    class Diretorios
    {
        public static void Executar() 
        {
            var novoDir = @"~\PastaCSharp".ParseHome();
            var novoDirDestino = @"~\PastaCSharpDestino".ParseHome();
            var novoDirListar = @"~".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("\n====== Pastas =========\n");
            var pastas = Directory.GetDirectories(novoDirListar);

            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            
            Console.WriteLine("\n====== Arquivos =========\n");

            var arquivos = Directory.GetFiles(novoDirListar);

            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
