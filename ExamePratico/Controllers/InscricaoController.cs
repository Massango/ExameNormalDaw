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
    public class InscricaoController : Controller
    {
        private ProjectoDB db = new ProjectoDB();

        //
        // GET: /Inscricao/

        public ActionResult Index()
        {
            return View(db.Inscricoes.ToList());
        }

        //
        // GET: /Inscricao/Details/5

        public ActionResult Details(int id = 0)
        {
            Inscricao inscricao = db.Inscricoes.Find(id);
            if (inscricao == null)
            {
                return HttpNotFound();
            }
            return View(inscricao);
        }

        //
        // GET: /Inscricao/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Inscricao/Create

        [HttpPost]
        public ActionResult Create(Inscricao inscricao)
        {
            if (ModelState.IsValid)
            {
                db.Inscricoes.Add(inscricao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inscricao);
        }

        //
        // GET: /Inscricao/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Inscricao inscricao = db.Inscricoes.Find(id);
            if (inscricao == null)
            {
                return HttpNotFound();
            }
            return View(inscricao);
        }

        //
        // POST: /Inscricao/Edit/5

        [HttpPost]
        public ActionResult Edit(Inscricao inscricao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inscricao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inscricao);
        }

        //
        // GET: /Inscricao/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Inscricao inscricao = db.Inscricoes.Find(id);
            if (inscricao == null)
            {
                return HttpNotFound();
            }
            return View(inscricao);
        }

        //
        // POST: /Inscricao/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Inscricao inscricao = db.Inscricoes.Find(id);
            db.Inscricoes.Remove(inscricao);
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