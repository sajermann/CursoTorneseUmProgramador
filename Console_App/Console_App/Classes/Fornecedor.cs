﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    public class Fornecedor : Base
    {
        public string Cnpj;
        public Fornecedor(string cnpj, string nome, string telefone, string cpf)
        {
            this.Cnpj = cnpj;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        } 

        public Fornecedor(){}

        public override void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);

            StreamWriter r = new StreamWriter(diretorioComArquivo());
            r.WriteLine("nome;telefone;cpf;");
            foreach (Fornecedor b in dados)
            {
                var linha = b.Nome + ";" + b.Telefone + ";" + b.Cpf + ";" + b.Cnpj + ";";
                r.WriteLine(linha);
            }
            r.Close();
        }

        public override List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(diretorioComArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(diretorioComArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');

                        var b = (Fornecedor)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseArquivo[0]);
                        b.SetTelefone(baseArquivo[1]);
                        b.SetCpf(baseArquivo[2]);
                        b.Cnpj = baseArquivo[3];
                        dados.Add(b);
                    }
                }
            }
            return dados;
        }

    }
}
