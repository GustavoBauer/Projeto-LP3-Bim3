using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLP3.Models;

namespace ProjetoLP3.Controllers
{
    [OutputCache(Location = System.Web.UI.OutputCacheLocation.None, NoStore = true)]
    public class LojaController : BaseController
    {
        private SeminarioLP3Container db = new SeminarioLP3Container();

        public ActionResult Index()
        {
            var lojas = db.Loja.Include("Rua").ToList();
            return View(lojas);
        }

        public ActionResult Inserir()
        {
            ViewBag.FkRua = new SelectList(db.Rua, "IdRua", "Nome");
            return View();
        }
        [HttpPost]
        public ActionResult Inserir(Loja loja)
        {
            if (ModelState.IsValid)
            {
                db.Loja.Add(loja);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FkRua = new SelectList(db.Rua, "IdRua", "Nome");
            return View(loja);
        }

        public ActionResult Alterar(int id)
        {
            Loja loja = db.Loja.Find(id);
            ViewBag.FkRua = new SelectList(db.Rua, "IdRua", "Nome");
            return View(loja);
        }
        [HttpPost]
        public ActionResult Alterar(Loja loja)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loja).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FkRua = new SelectList(db.Rua, "IdRua", "Nome");
            return View(loja);
        }

        public ActionResult Excluir(int id)
        {
            Loja loja = db.Loja.Find(id);
            ViewBag.FkRua = new SelectList(db.Rua, "IdRua", "Nome");
            return View(loja);
        }
        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(int id)
        {
            try
            {
                Loja loja = db.Loja.Find(id);
                db.Loja.Remove(loja);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("ErroExcluir");
            }
        }
        public ActionResult ErroExcluir()
        {
            return View();
        }

        public ActionResult Detalhes(int id)
        {
            Loja loja = db.Loja.Find(id);
            ViewBag.FkRua = new SelectList(db.Rua, "IdRua", "Nome");
            if (loja == null)
            {
                return HttpNotFound();
            }
            return View(loja);
        }

        public ActionResult ValidaCPNJ(string cnpj)
        {
            var val = db.Loja.Where(l => l.CNPJ == cnpj).FirstOrDefault();
            
            if (val != null)
                return Json(false, JsonRequestBehavior.AllowGet);
            else 
                return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}