using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NitinChandraMVC.DataConnections;
using NitinChandraMVC.Models;

namespace NitinChandraMVC.Controllers
{
    public class IssueBookController : Controller
    {
        private Db_Contexts db = new Db_Contexts();

        // GET: IssueBook
        public ActionResult Index()
        {
            var data = db.IssueBooks.ToList();

            List<Books> bookList = new List<Books>();

            bookList = db.Books.ToList();

            ViewBag.BooksList = new SelectList(bookList, "Id", "StdId");

            return View();
        }
        [HttpPost]
        public ActionResult Index(IssueBooks e)
        {


            IssueBooks objDate = new IssueBooks();

            db.IssueBooks.Add(e);
            db.SaveChanges();
            
            return View();
        }

        public ActionResult BooksDetail()
        {
            return View();
        }

        // GET: IssueBook/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    IssueBooks issueBooks = db.IssueBooks.Find(id);
        //    if (issueBooks == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(issueBooks);
        //}



        // GET: IssueBook/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IssueBook/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StdId,StdName,IssueDate,ReturnDate")] IssueBooks issueBooks)
        {
            if (ModelState.IsValid)
            {
                db.IssueBooks.Add(issueBooks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(issueBooks);
        }

        // GET: IssueBook/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IssueBooks issueBooks = db.IssueBooks.Find(id);
            if (issueBooks == null)
            {
                return HttpNotFound();
            }
            return View(issueBooks);
        }

        // POST: IssueBook/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StdId,StdName,IssueDate,ReturnDate")] IssueBooks issueBooks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(issueBooks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issueBooks);
        }

        // GET: IssueBook/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IssueBooks issueBooks = db.IssueBooks.Find(id);
            if (issueBooks == null)
            {
                return HttpNotFound();
            }
            return View(issueBooks);
        }

        // POST: IssueBook/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IssueBooks issueBooks = db.IssueBooks.Find(id);
            db.IssueBooks.Remove(issueBooks);
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
