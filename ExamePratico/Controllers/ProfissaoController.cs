using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamePratico.Models;

namespace ExamePratico.Controllers
{
    public class ProfissaoController : Controller
    {
        private ProjectoDB db = new ProjectoDB();

        //
        // GET: /Profissao/

        public ActionResult Index()
        {
            return View(db.Profissoes.ToList());
        }

        //
        // GET: /Profissao/Details/5

        public ActionResult Details(int id = 0)
        {
            Profissao profissao = db.Profissoes.Find(id);
            if (profissao == null)
            {
                return HttpNotFound();
            }
            return View(profissao);
        }

        //
        // GET: /Profissao/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Profissao/Create

        [HttpPost]
        public ActionResult Create(Profissao profissao)
        {
            if (ModelState.IsValid)
            {
                db.Profissoes.Add(profissao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(profissao);
        }

        //
        // GET: /Profissao/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Profissao profissao = db.Profissoes.Find(id);
            if (profissao == null)
            {
                return HttpNotFound();
            }
            return View(profissao);
        }

        //
        // POST: /Profissao/Edit/5

        [HttpPost]
        public ActionResult Edit(Profissao profissao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profissao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profissao);
        }

        //
        // GET: /Profissao/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Profissao profissao = db.Profissoes.Find(id);
            if (profissao == null)
            {
                return HttpNotFound();
            }
            return View(profissao);
        }

        //
        // POST: /Profissao/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Profissao profissao = db.Profissoes.Find(id);
            db.Profissoes.Remove(profissao);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}