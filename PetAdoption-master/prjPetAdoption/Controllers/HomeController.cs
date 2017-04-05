﻿using prjPetAdoption.Models;
using prjPetAdoption.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjPetAdoption.Controllers
{
    public class HomeController : Controller
    {
        AllAniDataViewModel AllAniData = new AllAniDataViewModel();
        private DbAnimal db = new DbAnimal();

        public ActionResult Index()
        {
            var list = (from t in db.aniDataPicOne
                        orderby t.animalID descending
                        select t).Take(6);

            AllAniData.aniDataPicOneList = list;
            return View(AllAniData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FAQ()
        {
            ViewBag.Message = "FAQ";

            return View();
        }

        public ActionResult Help()
        {
            ViewBag.Message = "Help";

            return View();
        }

        public ActionResult Information()
        {
            ViewBag.Message = "Information";

            return View();
        }

     

        public ActionResult aniwiki()
        {
            ViewBag.Message = "WIKI";

            return View();
        }


        public ActionResult mgIndex()
        {
           
            return View();
        }

        public ActionResult aniIndex()
        {
            return View();
        }
    }
}