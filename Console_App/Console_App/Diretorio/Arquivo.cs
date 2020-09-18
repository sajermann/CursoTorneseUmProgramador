using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Diretorio
{
    class Arquivo
    {
        public static void Ler(int numeroArquivo)
        {
            string caminhoRelativo = @"E:\Programação\Github\CursoTorneseUmProgramador\Console_App\Console_App\Diretorio\arq" + numeroArquivo + ".txt";
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
            string caminhoRelativo2 = @"E:\Programação\Github\CursoTorneseUmProgramador\Console_App\Console_App\Diretorio\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminhoRelativo))
            {
                Ler(numeroArquivo + 1);
            }
        }
    }
}
