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
    public class TipoEventoController : Controller
    {
        private ProjectoDB db = new ProjectoDB();

        //
        // GET: /TipoEvento/

        public ActionResult Index()
        {
            return View(db.TipoEventos.ToList());
        }

        //
        // GET: /TipoEvento/Details/5

        public ActionResult Details(int id = 0)
        {
            TipoEvento tipoevento = db.TipoEventos.Find(id);
            if (tipoevento == null)
            {
                return HttpNotFound();
            }
            return View(tipoevento);
        }

        //
        // GET: /TipoEvento/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoEvento/Create

        [HttpPost]
        public ActionResult Create(TipoEvento tipoevento)
        {
            if (ModelState.IsValid)
            {
                db.TipoEventos.Add(tipoevento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoevento);
        }

        //
        // GET: /TipoEvento/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TipoEvento tipoevento = db.TipoEventos.Find(id);
            if (tipoevento == null)
            {
                return HttpNotFound();
            }
            return View(tipoevento);
        }

        //
        // POST: /TipoEvento/Edit/5

        [HttpPost]
        public ActionResult Edit(TipoEvento tipoevento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoevento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoevento);
        }

        //
        // GET: /TipoEvento/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TipoEvento tipoevento = db.TipoEventos.Find(id);
            if (tipoevento == null)
            {
                return HttpNotFound();
            }
            return View(tipoevento);
        }

        //
        // POST: /TipoEvento/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoEvento tipoevento = db.TipoEventos.Find(id);
            db.TipoEventos.Remove(tipoevento);
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