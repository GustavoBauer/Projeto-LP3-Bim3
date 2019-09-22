using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLP3.Models;

namespace ProjetoLP3.Controllers
{
    public class TipoComercioController : BaseController
    {
        private SeminarioLP3Container db = new SeminarioLP3Container();

        public ActionResult Index()
        {
            var tiposComercio = db.TipoComercio.ToList();
            return View(tiposComercio);
        }

        public ActionResult Inserir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Inserir(TipoComercio tipoComercio)
        {
            if (ModelState.IsValid)
            {
                db.TipoComercio.Add(tipoComercio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoComercio);
        }

        public ActionResult Alterar(int id)
        {
            TipoComercio tipoComercio = db.TipoComercio.Find(id);
            return View(tipoComercio);
        }
        [HttpPost]
        public ActionResult Alterar(TipoComercio tipoComercio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoComercio).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoComercio);
        }

        public ActionResult Excluir(int id)
        {
            TipoComercio tipoComercio = db.TipoComercio.Find(id);
            return View(tipoComercio);
        }
        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(int id)
        {
            try
            {
                TipoComercio tipoComercio = db.TipoComercio.Find(id);
                db.TipoComercio.Remove(tipoComercio);
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
            TipoComercio tipoComercio = db.TipoComercio.Find(id);
            if (tipoComercio == null)
            {
                return HttpNotFound();
            }
            return View(tipoComercio);
        }
    }
}