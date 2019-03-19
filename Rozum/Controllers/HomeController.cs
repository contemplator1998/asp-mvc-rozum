using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rozum.Models;
using System.Data.Entity;

namespace Rozum.Controllers
{
    public class HomeController : Controller
    {
        ClientContext DB = new ClientContext();
        Random rand = new Random();

        public ActionResult Index()
        {            
            return View(DB.Clients);
        }
    }
}

