using Tela;
using System;
using System.Collections.Generic;
using System.IO;
using Classes;
using Componentes;

namespace Console_App
{
    //class Animal
    //{
    //    public string teste;
    //    public virtual string teste2()
    //    {
    //        return "";
    //    }
    //}

    //class Macaco : Animal
    //{
    //    public override string teste2()
    //    {
    //        return "sss";
    //    }
    //}

    partial class Animal
    {
        public string teste;
        partial void tt();
    }

    partial class Animal
    {
        public string teste2;
        partial void tt()
        {
            Console.WriteLine("Teste");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Email.Instancia.CorpoEmail = "Blablabla";
            Email.Instancia.Titulo = "Título do email";
            Email.Instancia.Origin = "contato@sajermann.com";
            Email.Instancia.Destino = "contato@sajermann.com";

            Email.Instancia.EnviarEmail();

            var a = new Animal();
            a.teste = "";

            var c = new Cachorro();
            c.Idade = 5;
            Console.WriteLine(c.Idade);
            Console.WriteLine(c.Idade2);
            c.Idade2 = 6;
            Console.WriteLine(c.Idade2);





            /*

            //Menu.Criar();
            Console.WriteLine("=============Cadastro de Cliente====================");
            Cliente c = new Cliente();
            c.Nome = "Cliente";
            c.Telefone = "23223";
            c.Cpf = "2156151515";
            c.Gravar();

            foreach (Cliente cl in new Cliente().Ler())
            {
                Console.WriteLine(cl.Nome);
                Console.WriteLine(cl.Telefone);
                Console.WriteLine(cl.Cpf);
                Console.WriteLine("=================================");
            }

            Console.WriteLine("=============Cadastro de Usuário====================");
            Usuario u = new Usuario();
            u.Nome = "Usuário";
            u.Telefone = "1199959595";
            u.Cpf = "2156151515";
            u.Gravar();
            
            foreach (Usuario us in new Usuario().Ler())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.Cpf);
                Console.WriteLine("=================================");
            }*/
        }
    }
}
