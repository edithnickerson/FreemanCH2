using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FreemanCH2.Models;
using Freeman_CH2.Models;
//hello World

namespace FreemanCH2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            int hour = DateTime.Now.Hour;

            ViewData["Greeting"] = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View("MyView");
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

        public IActionResult MyView()
        {
            return View();
        }

        //HTTP GET
        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse guestResponse)
        {
            //TODO: Process the guest response
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                //there was a problem
                return View();
            }
        }

        public IActionResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

        private IActionResult View(object p)
        {
            throw new NotImplementedException();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}