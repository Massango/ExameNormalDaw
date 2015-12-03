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
    public class OutrosParticipantesController : Controller
    {
        private ProjectoDB db = new ProjectoDB();

        //
        // GET: /OutrosParticipantes/

        public ActionResult Index()
        {
            return View(db.OutrosParticipantes.ToList());
        }

        //
        // GET: /OutrosParticipantes/Details/5

        public ActionResult Details(int id = 0)
        {
            OutrosParticipantes outrosparticipantes = db.OutrosParticipantes.Find(id);
            if (outrosparticipantes == null)
            {
                return HttpNotFound();
            }
            return View(outrosparticipantes);
        }

        //
        // GET: /OutrosParticipantes/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /OutrosParticipantes/Create

        [HttpPost]
        public ActionResult Create(OutrosParticipantes outrosparticipantes)
        {
            if (ModelState.IsValid)
            {
                db.OutrosParticipantes.Add(outrosparticipantes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(outrosparticipantes);
        }

        //
        // GET: /OutrosParticipantes/Edit/5

        public ActionResult Edit(int id = 0)
        {
            OutrosParticipantes outrosparticipantes = db.OutrosParticipantes.Find(id);
            if (outrosparticipantes == null)
            {
                return HttpNotFound();
            }
            return View(outrosparticipantes);
        }

        //
        // POST: /OutrosParticipantes/Edit/5

        [HttpPost]
        public ActionResult Edit(OutrosParticipantes outrosparticipantes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(outrosparticipantes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(outrosparticipantes);
        }

        //
        // GET: /OutrosParticipantes/Delete/5

        public ActionResult Delete(int id = 0)
        {
            OutrosParticipantes outrosparticipantes = db.OutrosParticipantes.Find(id);
            if (outrosparticipantes == null)
            {
                return HttpNotFound();
            }
            return View(outrosparticipantes);
        }

        //
        // POST: /OutrosParticipantes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            OutrosParticipantes outrosparticipantes = db.OutrosParticipantes.Find(id);
            db.OutrosParticipantes.Remove(outrosparticipantes);
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