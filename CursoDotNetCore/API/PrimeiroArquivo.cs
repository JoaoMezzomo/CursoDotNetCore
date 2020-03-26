using System;
using System.IO;

namespace CursoDotNetCore.API
{
    public static class ExtensaoString 
    {
        public static string ParseHome(this string path) 
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return path = path.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    {
        public static void Executar() 
        {
            var path = @"~\primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Teste de escrita");
                    sw.WriteLine("Primeiro Arquivo");
                    sw.WriteLine("Tche!");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("É possível adicionar textos");
            }
        }
    }
}
