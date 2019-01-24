using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DragonFormsVsModelBinding.Models;
using Microsoft.AspNetCore.Http;

namespace DragonFormsVsModelBinding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet] //Default - Optional
        public IActionResult DragonForm()
        {
            return View();
        }

        //This version is used, when the form
        //is submitted (or POSTed) to the server
         public IActionResult DragonForm(IFormCollection data)
        {
          string dragonName = data["dragon_name"];

            Dragon drag = new Dragon();
            drag.Name = dragonName;

            //DragonDB.AddDragon(dragon);

            ViewData["Msg"] = "Thanks for adding" + dragonName;
            return View();
        }

        public IActionResult DragonFormModelBound(Dragon drag)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View(drag);
        }
    }
}
