using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    public class Usuario : Cliente
    {
        /// <summary>
        /// Construtor com três parâmetros
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        public Usuario(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        } 
        public Usuario(){}

        private static string caminhoBase()
        {
            return ConfigurationManager.AppSettings["BaseDeUsuarios"];
        }

        public override void Olhar()
        {
            Console.WriteLine("O usuário " + this.Nome + " não tem o sobrenome, pois este é atributo da classe pai, está olhando para mim");
            Console.WriteLine("======================================");
            base.Olhar();
        }
        public override void Gravar()
        {
            var usuario = Usuario.LerUsuarios();
            usuario.Add(this);
            
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
                foreach (Cliente c in usuario)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
           
        }
        public static List<Usuario> LerUsuarios()
        {
            var usuarios = new List<Usuario>();
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
                        var usuarioArquivo = linha.Split(';');
                        //var usuario = new Usuario(usuarioArquivo[0],usuarioArquivo[1],usuarioArquivo[2]);
                        var usuario = new Usuario
                        {
                            Nome = usuarioArquivo[0],
                            Telefone = usuarioArquivo[1],
                            Cpf = usuarioArquivo[2]
                        };
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }
    }
}
