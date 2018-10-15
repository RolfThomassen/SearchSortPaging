﻿using System;
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
            ViewBag.SortByPostnr = sort == "Postnr" ? "descending postnr" : "Postnr";

            //here we are converting the db.Students to AsQueryable so that we can invoke all the extension methods on variable records.  
            var records = db.vw_Co2Db_Virksomheder.AsQueryable();


            //if a user choose the radio button option as Subject  
            switch (option)
            {
                case "Postnr":
                    records = records.Where(x => x.Postnr.Contains(search) || search == null);
                    break;
                case "Kontakt":
                    records = records.Where(x => x.AdminNavn.Contains(search) || search == null);
                    break;
                default:
                    records = records.Where(x => x.Firmanavn.Contains(search) || search == null);
                    break;
            }

            switch (sort)
            {
                case "descending name":
                    records = records.OrderByDescending(x => x.Firmanavn);
                    break;

                case "descending gender":
                    records = records.OrderByDescending(x => x.Postnr);
                    break;

                case "Postnr":
                    records = records.OrderBy(x => x.Postnr);
                    break;

                default:
                    records = records.OrderBy(x => x.Firmanavn);
                    break;

            }

            return View(records.ToPagedList(pageNumber ?? 1, 15));
        }


        public ActionResult Details(int id)
        {
            return View();
        }

    }
}