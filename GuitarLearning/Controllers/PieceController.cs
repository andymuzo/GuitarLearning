using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GuitarLearning.DAL;
using GuitarLearning.Models;

namespace GuitarLearning.Controllers
{
    public class PieceController : Controller
    {
        private MusicContext db = new MusicContext();

        // GET: Piece
        public ActionResult Index()
        {
            return View(db.Pieces.ToList());
        }

        // GET: Piece/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Piece piece = db.Pieces.Find(id);
            if (piece == null)
            {
                return HttpNotFound();
            }
            return View(piece);
        }

        // GET: Piece/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Piece/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PieceID,Composer,Name,YearPublished,Style,Description,Grade,VideoLink")] Piece piece)
        {
            if (ModelState.IsValid)
            {
                db.Pieces.Add(piece);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(piece);
        }

        // GET: Piece/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Piece piece = db.Pieces.Find(id);
            if (piece == null)
            {
                return HttpNotFound();
            }
            return View(piece);
        }

        // POST: Piece/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PieceID,Composer,Name,YearPublished,Style,Description,Grade,VideoLink")] Piece piece)
        {
            if (ModelState.IsValid)
            {
                db.Entry(piece).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(piece);
        }

        // GET: Piece/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Piece piece = db.Pieces.Find(id);
            if (piece == null)
            {
                return HttpNotFound();
            }
            return View(piece);
        }

        // POST: Piece/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Piece piece = db.Pieces.Find(id);
            db.Pieces.Remove(piece);
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
