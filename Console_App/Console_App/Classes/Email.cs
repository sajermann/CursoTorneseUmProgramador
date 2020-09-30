using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Email
    {
        private Email() { }

        private static Email instancia;
        public string Origin;
        public string Destino;
        public string Titulo;
        public string CorpoEmail;

        public void EnviarEmail()
        {
            Console.WriteLine("Enviando email para " + Destino + "\n" + "com o título " + Titulo + "\n" + CorpoEmail);
        }

        public static Email Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Email();
                }
                return instancia;
            }
        }
    }
}
