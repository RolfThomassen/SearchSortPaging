using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SearchSortPaging.Models;
using PagedList;

namespace SearchSortPaging.Controllers
{
    public class PostnrController : Controller
    {
        private vicjos1_rescuetekniq_Entities db = new vicjos1_rescuetekniq_Entities();
        private rescuetekniq_sp_Entities sp = new rescuetekniq_sp_Entities();
        
        // GET: Postnr
        // the first parameter is the option that we choose and the second parameter will use the textbox value  
        public ActionResult Index(string option, string search, int? pageNumber, string sort)
        {
            //if the sort parameter is null or empty then we are initializing the value as descending name  
            //ViewBag.SortByPostnr = sort == "Postnr" ? "descending postnr" : "postnr";
            ViewBag.SortByPostnr = string.IsNullOrEmpty(sort) ? "descending postnr" : "postnr";
            ViewBag.SortByBynavn = sort == "bynavn" ? "descending bynavn" : "bynavn";
            ViewBag.SortByGade = sort == "gade" ? "descending gade" : "gade";
            ViewBag.SortByLand = sort == "land" ? "descending land" : "land";

            //here we are converting the db.Students to AsQueryable so that we can invoke all the extension methods on variable records.  
            var records = db.vw_Co2Db_Postnr.AsQueryable();

            //if a user choose the radio button option as Subject  
            switch (option)
            {
                case "bynavn": records = records.Where(x => x.Bynavn.Contains(search) || search == null); break;
                case "gade": records = records.Where(x => x.Gade.Contains(search) || search == null); break;
                default: records = records.Where(x => x.Postnr.Contains(search) || search == null); break;
            }

            switch (sort)
            {
                case "descending postnr": records = records.OrderByDescending(x => x.Postnr); break;
                case "descending bynavn": records = records.OrderByDescending(x => x.Bynavn); break;
                case "descending gade": records = records.OrderByDescending(x => x.Gade); break;
                case "descending land": records = records.OrderByDescending(x => x.Land); break;
                case "bynavn": records = records.OrderBy(x => x.Bynavn); break;
                case "gade": records = records.OrderBy(x => x.Gade); break;
                case "land": records = records.OrderBy(x => x.Land); break;
                default: records = records.OrderBy(x => x.Postnr); break;
            }
            return View(records.ToPagedList(pageNumber ?? 1, 20));
        }



        // GET: Postnr/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_Co2Db_Postnr vw_Co2Db_Postnr = db.vw_Co2Db_Postnr.Find(id);
            if (vw_Co2Db_Postnr == null)
            {
                return HttpNotFound();
            }
            return View(vw_Co2Db_Postnr);
        }

        // GET: Postnr/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Postnr/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Postnr,Bynavn,Gade,Firma,LandID,Provins,Land")] vw_Co2Db_Postnr Rec)
        {
            if (ModelState.IsValid)
            {
                System.Data.Entity.Core.Objects.ObjectParameter iD = null;
                sp.Co2Db_Postnr_Insert(Rec.Postnr, Rec.Bynavn, Rec.Gade, Rec.Firma, Rec.Provins, Rec.LandID, iD);
                //db.vw_Co2Db_Postnr.Add(vw_Co2Db_Postnr_Rec);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Rec);
        }

        // GET: Postnr/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_Co2Db_Postnr vw_Co2Db_Postnr = db.vw_Co2Db_Postnr.Find(id);
            if (vw_Co2Db_Postnr == null)
            {
                return HttpNotFound();
            }
            return View(vw_Co2Db_Postnr);
        }

        // POST: Postnr/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Postnr,Bynavn,Gade,Firma,LandID,Provins,Land")] vw_Co2Db_Postnr Rec)
        {
            if (ModelState.IsValid)
            {
                sp.Co2Db_Postnr_Update(Rec.ID, Rec.Postnr, Rec.Bynavn, Rec.Gade, Rec.Firma, Rec.Provins, Rec.LandID);

                //db.Entry(Rec).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Rec);
        }

        // GET: Postnr/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_Co2Db_Postnr vw_Co2Db_Postnr = db.vw_Co2Db_Postnr.Find(id);
            if (vw_Co2Db_Postnr == null)
            {
                return HttpNotFound();
            }
            return View(vw_Co2Db_Postnr);
        }

        // POST: Postnr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vw_Co2Db_Postnr vw_Co2Db_Postnr = db.vw_Co2Db_Postnr.Find(id);
            db.vw_Co2Db_Postnr.Remove(vw_Co2Db_Postnr);
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
