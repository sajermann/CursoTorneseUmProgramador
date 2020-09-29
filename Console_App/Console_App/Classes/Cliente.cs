using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    public class Cliente : Base
    {

        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        public Cliente(int telefone)
        {
            this.Telefone = telefone.ToString();
        }

        public Cliente(){}

        public static string Teste;

    }
}
