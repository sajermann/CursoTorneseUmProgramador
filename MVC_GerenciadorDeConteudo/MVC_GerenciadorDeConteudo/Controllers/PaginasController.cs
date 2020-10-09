using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Database;
using MVC_GerenciadorDeConteudo.Business;

namespace MVC_GerenciadorDeConteudo.Controllers
{
    public class PaginasController : Controller
    {
        public ActionResult Index()
        {
            var a = new Pagina();
            
            ViewBag.Paginas = a.Lista();

            return View();
        }
        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
        public void Create()
        {
            var pagina = new Pagina();
            pagina.Nome = Request["nome"];
            pagina.Conteudo = Request["conteudo"];
            pagina.Data = Convert.ToDateTime(Request["data"]);
            pagina.Save();
            Response.Redirect("/paginas");
        }

    }
}