﻿using prjPetAdoption.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjPetAdoption.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public DbAnimal db = new DbAnimal();

    }
}