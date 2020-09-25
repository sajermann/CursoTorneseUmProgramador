using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    public class Cliente
    {
        /// <summary>
        /// Construtor com três parâmetros
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        /// <summary>
        /// Construtor da Class
        /// </summary>
        /// <param name="nome">Preencher o nome do objeto</param>
        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        /// <summary>
        /// Construtor com parâmetro telefone inteiro
        /// </summary>
        /// <param name="telefone">Telefone Inteiro</param>
        public Cliente(int telefone)
        {
            this.Telefone = telefone.ToString();
        }
        /// <summary>
        /// Construtor sem parâmetros
        /// </summary>
        public Cliente(){}

        public static string Teste;

        public string Nome;
        public string Telefone;
        public string Cpf;

        private string sobrenome = "Santos";

        public virtual void Gravar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);

            if (File.Exists(caminhoBase()))
            {
                //string conteudo = "nome;telefone;cpf;\n";
                //foreach (Cliente c in clientes)
                //{
                //    conteudo += c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";\n";
                //}
                //File.WriteAllText(caminhoBaseClientes(), conteudo);

                //Metódo 2 para gravar
                StreamWriter r = new StreamWriter(caminhoBase());
                r.WriteLine("nome;telefone;cpf;");
                foreach (Cliente c in clientes)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
        }

        public virtual void Olhar()
        {
            Console.WriteLine("O cliente " + this.Nome + " " + this.sobrenome + " está olhando para mim");
        }

        private static string caminhoBase()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(caminhoBase()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBase()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');
                        //var cliente = new Cliente(clienteArquivo[0],clienteArquivo[1],clienteArquivo[2]);
                        var cliente = new Cliente {
                            Nome = clienteArquivo[0],
                            Telefone = clienteArquivo[1],
                            Cpf = clienteArquivo[2]
                        };
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }

    }
}
