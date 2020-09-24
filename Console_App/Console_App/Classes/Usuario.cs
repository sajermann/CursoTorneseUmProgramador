using System;
using System.Collections.Generic;
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
    }
}
