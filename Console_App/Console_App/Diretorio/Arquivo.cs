using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Configuration;

namespace Diretorio
{
    class Arquivo
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }

        public static void Ler(int numeroArquivo)
        {
            string caminhoRelativo = caminhoArquivo() + "arq" + numeroArquivo + ".txt";
            Console.WriteLine("========== Lendo Arquivo ==========\n" + caminhoRelativo);
            if (File.Exists(caminhoRelativo))
            {
                using (StreamReader arquivo = File.OpenText(caminhoRelativo))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string caminhoRelativo2 = caminhoArquivo() + "arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminhoRelativo))
            {
                Ler(numeroArquivo + 1);
            }
        }
    }
}
