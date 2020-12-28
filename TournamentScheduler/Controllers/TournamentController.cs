using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TournamentScheduler.Controllers
{
    public class TournamentController : Controller
    {
        [HttpPost]
        public ActionResult Index()
        {




            return View();
        }
    }
}