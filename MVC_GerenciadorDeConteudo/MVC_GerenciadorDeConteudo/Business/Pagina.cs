using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MVC_GerenciadorDeConteudo.Business
{
    public class Pagina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public List<Pagina> Lista()
        {
            var lista = new List<Pagina>();
            var paginaDb = new Database.PaginaDB();
            foreach(DataRow row in paginaDb.Lista().Rows)
            {
                var pagina = new Pagina();
                pagina.Id = Convert.ToInt32(row["id"]);
                pagina.Nome = Convert.ToString(row["nome"]);
                pagina.Conteudo = row["conteudo"].ToString();
                pagina.Data = Convert.ToDateTime(row["data"]);

                lista.Add(pagina);
            }

            return lista;
            
        }

        internal void Save()
        {
            new Database.PaginaDB().Salvar(this.Id, this.Nome, this.Conteudo, this.Data);
        }

        internal static Pagina BuscaPorId(int id)
        {
            var pagina = new Pagina();
            var paginaDb = new Database.PaginaDB();
            foreach (DataRow row in paginaDb.BuscaPorId(id).Rows)
            {
                
                pagina.Id = Convert.ToInt32(row["id"]);
                pagina.Nome = Convert.ToString(row["nome"]);
                pagina.Conteudo = row["conteudo"].ToString();
                pagina.Data = Convert.ToDateTime(row["data"]);
            }

            return pagina;
        }
    }
}