using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLP3.Models;

namespace ProjetoLP3.Controllers
{
    public class UsuarioController : Controller
    {
        private SeminarioLP3Container db = new SeminarioLP3Container();

        public ActionResult Index()
        {
            var usuarios = db.Usuario.ToList();
            return View(usuarios);
        }

        public ActionResult Inserir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Inserir(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        public ActionResult Alterar(int id)
        {
            Usuario usuario = db.Usuario.Find(id);
            return View(usuario);
        }
        [HttpPost]
        public ActionResult Alterar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        public ActionResult Excluir(int id)
        {
            Usuario usuario = db.Usuario.Find(id);
            return View(usuario);
        }
        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(int id)
        {
            try
            {
                Usuario usuario = db.Usuario.Find(id);
                db.Usuario.Remove(usuario);
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
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }
    }
}