using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula_3.Models;

namespace Aula_3.Controllers
{
    public class DiscoController : Controller
    {
        private static DiscoDados discoDados = new DiscoDados();
        // GET: Disco
        public ActionResult Index()
        {
            return View(discoDados.listaDisco);
        }
        public ActionResult AdicionarDisco()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdicionarDisco(Disco discos)
        {
            discoDados.CriaDiscos(discos);
            return RedirectToAction("Index");
        }
        public ActionResult ApagaDisco(string id)
        {
            try
            {
                if(discoDados.ApagaDisco(id))
                {
                    ViewBag.AlertMsg = "Funcionário excluído com sucesso";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}