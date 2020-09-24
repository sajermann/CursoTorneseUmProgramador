using Tela;
using System;
using System.Collections.Generic;
using System.IO;
using Classes;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu.Criar();
            Console.WriteLine("=============Cadastro de Cliente====================");
            Cliente c = new Cliente();
            c.Nome = "San";
            c.Telefone = "uihsjduih";
            c.Cpf = "2156151515";
            c.Gravar();

            foreach (Cliente cl in Usuario.LerClientes())
            {
                Console.WriteLine(cl.Nome);
                Console.WriteLine(cl.Telefone);
                Console.WriteLine(cl.Cpf);
                Console.WriteLine("=================================");
            }

            Console.WriteLine("=============Cadastro de Usuario====================");
            Usuario u = new Usuario();
            u.Nome = "San";
            u.Telefone = "uihsjduih";
            u.Cpf = "2156151515";
            u.Gravar();

            foreach(Usuario us in Usuario.LerUsuarios())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.Cpf);
                Console.WriteLine("=================================");
            }
        
        }
    }
}
