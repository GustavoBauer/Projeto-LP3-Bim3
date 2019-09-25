using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLP3.Models;

namespace ProjetoLP3.Controllers
{
    public class HomeController : Controller
    {
        private SeminarioLP3Container db = new SeminarioLP3Container();

        public ActionResult Login()
        {
            ViewBag.Title = "Autenticação";
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Bairro = new SelectList(db.Bairro, "IdBairro", "Nome");
            ViewBag.TipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            ViewBag.Rua = new SelectList(db.Rua, "IdRua", "Nome");
            return View();
        }

        public ActionResult Pesquisar1(Pesquisa1 pesquisa)
        {
            var ruas = from r in db.Rua
                       where r.FkBairro == pesquisa.IdBairro && r.FkTipoComercio == pesquisa.IdComercio
                       select new ResultadoPesquisa1
                       {
                           Nome = r.Nome,
                           CEP = r.CEP
                       };
            return Json(ruas, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Pesquisar2(Pesquisa2 pesquisa)
        {
            var lojas = from l in db.Loja
                        where l.FkRua == pesquisa.IdRua
                        select new ResultadoPesquisa2
                        {
                            NomeComercial = l.NomeComercial,
                            CNPJ = l.CNPJ,
                            RazaoSocial = l.RazaoSocial,
                            Telefone = l.Telefone,
                            Site = l.Site
                        };
            return Json(lojas, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Pesquisar3(Pesquisa3 pesquisa)
        {
            var ruas = from r in db.Rua
                       where r.FkTipoComercio == pesquisa.IdComercio
                       select new ResultadoPesquisa1
                       {
                           Nome = r.Nome,
                           CEP = r.CEP
                       };
            return Json(ruas, JsonRequestBehavior.AllowGet);
        }

    }
}