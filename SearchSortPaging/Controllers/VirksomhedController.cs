using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SearchSortPaging.Models;
using PagedList;

namespace SearchSortPaging.Controllers
{
    public class VirksomhedController : Controller
    {
        vicjos1_rescuetekniq_Entities db = new vicjos1_rescuetekniq_Entities();

        // GET: Virksomhed
        //public ActionResult Index()
        //{
        //    List<vw_Co2Db_Virksomheder> VirkList = db.vw_Co2Db_Virksomheder.ToList();
        //    return View(VirkList);
        //}

        //the first parameter is the option that we choose and the second parameter will use the textbox value  
        public ActionResult Index(string option, string search, int? pageNumber, string sort)
        {
            //if the sort parameter is null or empty then we are initializing the value as descending name  
            ViewBag.SortByName = string.IsNullOrEmpty(sort) ? "descending name" : "";
            //if the sort value is gender then we are initializing the value as descending gender  
            ViewBag.SortByGender = sort == "Gender" ? "descending gender" : "Gender";

            //here we are converting the db.Students to AsQueryable so that we can invoke all the extension methods on variable records.  
            var records = db.vw_Co2Db_Virksomheder.AsQueryable();


            //if a user choose the radio button option as Subject  
            switch (option)
            {
                case "Postnr":
                    return View(db.vw_Co2Db_Virksomheder.Where(x => x.Postnr.Contains(search) || search == null).ToList().ToPagedList(pageNumber ?? 1, 15));
                    break;
                case "Kontakt":
                    return View(db.vw_Co2Db_Virksomheder.Where(x => x.AdminNavn.Contains(search) || search == null).ToList().ToPagedList(pageNumber ?? 1, 15));
                    break;
                default:
                    return View(db.vw_Co2Db_Virksomheder.Where(x => x.Firmanavn.Contains(search) || search == null).ToList().ToPagedList(pageNumber ?? 1, 15));
                    break;
            }
            //return View(records.ToPagedList(pageNumber ?? 1, 3));

        }


        public ActionResult Details(int id)
        {
            return View();
        }

    }
}