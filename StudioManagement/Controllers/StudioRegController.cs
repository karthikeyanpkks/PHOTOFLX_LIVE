using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudioManagement.Models;

namespace StudioManagement.Controllers
{
    public class StudioRegController : Controller
    {
        private StudioMng db = new StudioMng();

        //
        // GET: /StudioReg/

        public ActionResult Index()
        {
            return View(db.StudioReg.ToList());
        }

        //
        // GET: /StudioReg/Details/5

        public ActionResult Details(int id = 0)
        {
            StudioReg studioreg = db.StudioReg.Find(id);
            if (studioreg == null)
            {
                return HttpNotFound();
            }
            return View(studioreg);
        }

        //
        // GET: /StudioReg/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /StudioReg/Create

        [HttpPost]
        public ActionResult Create(StudioReg studioreg)
        {
            if (ModelState.IsValid)
            {
                db.StudioReg.Add(studioreg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studioreg);
        }

        //
        // GET: /StudioReg/Edit/5

        public ActionResult Edit(int id = 0)
        {
            StudioReg studioreg = db.StudioReg.Find(id);
            if (studioreg == null)
            {
                return HttpNotFound();
            }
            return View(studioreg);
        }

        //
        // POST: /StudioReg/Edit/5

        [HttpPost]
        public ActionResult Edit(StudioReg studioreg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studioreg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studioreg);
        }

        //
        // GET: /StudioReg/Delete/5

        public ActionResult Delete(int id = 0)
        {
            StudioReg studioreg = db.StudioReg.Find(id);
            if (studioreg == null)
            {
                return HttpNotFound();
            }
            return View(studioreg);
        }

        //
        // POST: /StudioReg/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            StudioReg studioreg = db.StudioReg.Find(id);
            db.StudioReg.Remove(studioreg);
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