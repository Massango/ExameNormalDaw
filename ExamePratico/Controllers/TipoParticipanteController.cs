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
    public class TipoParticipanteController : Controller
    {
        private ProjectoDB db = new ProjectoDB();

        //
        // GET: /TipoParticipante/

        public ActionResult Index()
        {
            return View(db.TipoParticipantes.ToList());
        }

        //
        // GET: /TipoParticipante/Details/5

        public ActionResult Details(int id = 0)
        {
            TipoParticipante tipoparticipante = db.TipoParticipantes.Find(id);
            if (tipoparticipante == null)
            {
                return HttpNotFound();
            }
            return View(tipoparticipante);
        }

        //
        // GET: /TipoParticipante/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoParticipante/Create

        [HttpPost]
        public ActionResult Create(TipoParticipante tipoparticipante)
        {
            if (ModelState.IsValid)
            {
                db.TipoParticipantes.Add(tipoparticipante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoparticipante);
        }

        //
        // GET: /TipoParticipante/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TipoParticipante tipoparticipante = db.TipoParticipantes.Find(id);
            if (tipoparticipante == null)
            {
                return HttpNotFound();
            }
            return View(tipoparticipante);
        }

        //
        // POST: /TipoParticipante/Edit/5

        [HttpPost]
        public ActionResult Edit(TipoParticipante tipoparticipante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoparticipante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoparticipante);
        }

        //
        // GET: /TipoParticipante/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TipoParticipante tipoparticipante = db.TipoParticipantes.Find(id);
            if (tipoparticipante == null)
            {
                return HttpNotFound();
            }
            return View(tipoparticipante);
        }

        //
        // POST: /TipoParticipante/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoParticipante tipoparticipante = db.TipoParticipantes.Find(id);
            db.TipoParticipantes.Remove(tipoparticipante);
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