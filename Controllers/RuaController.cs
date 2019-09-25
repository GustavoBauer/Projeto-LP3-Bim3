using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLP3.Models;

namespace ProjetoLP3.Controllers
{
    [OutputCache(Location = System.Web.UI.OutputCacheLocation.None, NoStore = true)]
    public class RuaController : BaseController
    {
        private SeminarioLP3Container db = new SeminarioLP3Container();

        public ActionResult Index()
        {
            var ruas = db.Rua.Include("Bairro").Include("TipoComercio").ToList();
            return View(ruas);
        }

        public ActionResult Inserir()
        {
            ViewBag.FkBairro = new SelectList(db.Bairro, "IdBairro", "Nome");
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            return View();
        }
        [HttpPost]
        public ActionResult Inserir(Rua rua)
        {
            if (ModelState.IsValid)
            {
                db.Rua.Add(rua);
                db.SaveChanges();
                return RedirectToAction("Index");
            }           
            ViewBag.FkBairro = new SelectList(db.Bairro, "IdBairro", "Nome");
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            return View(rua);
        }

        public ActionResult Alterar(int id)
        {
            Rua rua = db.Rua.Find(id);
            ViewBag.FkBairro = new SelectList(db.Bairro, "IdBairro", "Nome");
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            return View(rua);
        }
        [HttpPost]
        public ActionResult Alterar(Rua rua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rua).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FkBairro = new SelectList(db.Bairro, "IdBairro", "Nome");
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            return View(rua);
        }

        public ActionResult Excluir(int id)
        {
            Rua rua = db.Rua.Find(id);
            ViewBag.FkBairro = new SelectList(db.Bairro, "IdBairro", "Nome");
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            return View(rua);
        }
        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(int id)
        {
            try
            {
                Rua rua = db.Rua.Find(id);
                db.Rua.Remove(rua);
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
            Rua rua = db.Rua.Find(id);
            ViewBag.FkBairro = new SelectList(db.Bairro, "IdBairro", "Nome");
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            if (rua == null)
            {
                return HttpNotFound();
            }
            return View(rua);
        }
    }
}