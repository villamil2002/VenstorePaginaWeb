using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PaginaWebGaes23.Data;
using PaginaWebGaes23.Models;

namespace PaginaWebGaes23.Controllers
{
    public class DBCiudadesController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: DBCiudades
        public ActionResult Index()
        {
            return View(db.PaginaWebGaes231.ToList());
        }

        // GET: DBCiudades/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBCiudadesDROP dBCiudadesDROP = db.PaginaWebGaes231.Find(id);
            if (dBCiudadesDROP == null)
            {
                return HttpNotFound();
            }
            return View(dBCiudadesDROP);
        }

        // GET: DBCiudades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DBCiudades/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCiudad,Descripcion")] DBCiudadesDROP dBCiudadesDROP)
        {
            if (ModelState.IsValid)
            {
                db.PaginaWebGaes231.Add(dBCiudadesDROP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dBCiudadesDROP);
        }

        // GET: DBCiudades/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBCiudadesDROP dBCiudadesDROP = db.PaginaWebGaes231.Find(id);
            if (dBCiudadesDROP == null)
            {
                return HttpNotFound();
            }
            return View(dBCiudadesDROP);
        }

        // POST: DBCiudades/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCiudad,Descripcion")] DBCiudadesDROP dBCiudadesDROP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dBCiudadesDROP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dBCiudadesDROP);
        }

        // GET: DBCiudades/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBCiudadesDROP dBCiudadesDROP = db.PaginaWebGaes231.Find(id);
            if (dBCiudadesDROP == null)
            {
                return HttpNotFound();
            }
            return View(dBCiudadesDROP);
        }

        // POST: DBCiudades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DBCiudadesDROP dBCiudadesDROP = db.PaginaWebGaes231.Find(id);
            db.PaginaWebGaes231.Remove(dBCiudadesDROP);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
