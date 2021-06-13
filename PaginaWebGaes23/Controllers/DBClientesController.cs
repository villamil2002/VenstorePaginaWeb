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
    public class DBClientesController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: DBClientes
        public ActionResult Index()
        {
            return View(db.PaginaWebGaes23.ToList());
        }

        // GET: DBClientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBClientesDROP dBClientesDROP = db.PaginaWebGaes23.Find(id);
            if (dBClientesDROP == null)
            {
                return HttpNotFound();
            }
            return View(dBClientesDROP);
        }

        // GET: DBClientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DBClientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDocumento,Nombres,Apellidos")] DBClientesDROP dBClientesDROP)
        {
            if (ModelState.IsValid)
            {
                db.PaginaWebGaes23.Add(dBClientesDROP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dBClientesDROP);
        }

        // GET: DBClientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBClientesDROP dBClientesDROP = db.PaginaWebGaes23.Find(id);
            if (dBClientesDROP == null)
            {
                return HttpNotFound();
            }
            return View(dBClientesDROP);
        }

        // POST: DBClientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDocumento,Nombres,Apellidos")] DBClientesDROP dBClientesDROP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dBClientesDROP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dBClientesDROP);
        }

        // GET: DBClientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBClientesDROP dBClientesDROP = db.PaginaWebGaes23.Find(id);
            if (dBClientesDROP == null)
            {
                return HttpNotFound();
            }
            return View(dBClientesDROP);
        }

        // POST: DBClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DBClientesDROP dBClientesDROP = db.PaginaWebGaes23.Find(id);
            db.PaginaWebGaes23.Remove(dBClientesDROP);
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
