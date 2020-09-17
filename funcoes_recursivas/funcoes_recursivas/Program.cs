using System;
using System.IO;

namespace funcoes_recursivas
{
    class Program
    {

        private static void LerArquivo(int numeroArquivo)
        {
            string caminhoRelativo = @"E:\Programação\Github\CursoTorneseUmProgramador\funcoes_recursivas\funcoes_recursivas\arquivos\arq" + numeroArquivo + ".txt";
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
            string caminhoRelativo2 = @"E:\Programação\Github\CursoTorneseUmProgramador\funcoes_recursivas\funcoes_recursivas\arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminhoRelativo))
            {
                LerArquivo(numeroArquivo + 1);
            }
        }
        static void Main(string[] args)
        {
            LerArquivo(1);
            Console.Read();
        }
    }
}
