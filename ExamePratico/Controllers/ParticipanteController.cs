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
    public class ParticipanteController : Controller
    {
        private ProjectoDB db = new ProjectoDB();

        //
        // GET: /Participante/

        public ActionResult Index()
        {
            return View(db.Participantes.ToList());
        }

        //
        // GET: /Participante/Details/5

        public ActionResult Details(int id = 0)
        {
            Participante participante = db.Participantes.Find(id);
            if (participante == null)
            {
                return HttpNotFound();
            }
            return View(participante);
        }

        //
        // GET: /Participante/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Participante/Create

        [HttpPost]
        public ActionResult Create(Participante participante)
        {
            if (ModelState.IsValid)
            {
                db.Participantes.Add(participante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(participante);
        }

        //
        // GET: /Participante/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Participante participante = db.Participantes.Find(id);
            if (participante == null)
            {
                return HttpNotFound();
            }
            return View(participante);
        }

        //
        // POST: /Participante/Edit/5

        [HttpPost]
        public ActionResult Edit(Participante participante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(participante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(participante);
        }

        //
        // GET: /Participante/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Participante participante = db.Participantes.Find(id);
            if (participante == null)
            {
                return HttpNotFound();
            }
            return View(participante);
        }

        //
        // POST: /Participante/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Participante participante = db.Participantes.Find(id);
            db.Participantes.Remove(participante);
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