using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLP3.Models;

namespace ProjetoLP3.Controllers
{
    [OutputCache(Location = System.Web.UI.OutputCacheLocation.None, NoStore = true)]
    public class CategoriaProdutoController : BaseController
    {
        private SeminarioLP3Container db = new SeminarioLP3Container();

        public ActionResult Index()
        {
            var categoriasProduto = db.CategoriaProduto.Include("TipoComercio").ToList();
            return View(categoriasProduto);
        }

        public ActionResult Inserir()
        {
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            return View();
        }
        [HttpPost]
        public ActionResult Inserir(CategoriaProduto categoriaProduto)
        {
            if (ModelState.IsValid)
            {
                db.CategoriaProduto.Add(categoriaProduto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            return View(categoriaProduto);
        }

        public ActionResult Alterar(int id)
        {
            CategoriaProduto categoriaProduto = db.CategoriaProduto.Find(id);
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            return View(categoriaProduto);
        }
        [HttpPost]
        public ActionResult Alterar(CategoriaProduto categoriaProduto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaProduto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            return View(categoriaProduto);
        }

        public ActionResult Excluir(int id)
        {
            CategoriaProduto categoriaProduto = db.CategoriaProduto.Find(id);
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            return View(categoriaProduto);
        }
        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(int id)
        {
            try
            {
                CategoriaProduto categoriaProduto = db.CategoriaProduto.Find(id);
                db.CategoriaProduto.Remove(categoriaProduto);
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
            CategoriaProduto categoriaProduto = db.CategoriaProduto.Find(id);
            ViewBag.FkTipoComercio = new SelectList(db.TipoComercio, "IdComercio", "Nome");
            if (categoriaProduto == null)
            {
                return HttpNotFound();
            }
            return View(categoriaProduto);
        }
    }
}