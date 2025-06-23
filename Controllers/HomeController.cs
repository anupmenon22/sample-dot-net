using System;
using SampleDotNetApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace SampleDotNetApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new MessageModel());
        }

        // POST: Home
        [HttpPost]
        public ActionResult Index(MessageModel model)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(model.Name))
                {
                    model.Result = "Please enter your name.";
                    model.IsSuccess = false;
                }
                else if (string.IsNullOrEmpty(model.Message))
                {
                    model.Result = "Please enter a message.";
                    model.IsSuccess = false;
                }
                else
                {
                    model.Result = $"Hello {model.Name}! Your message '{model.Message}' was received at {DateTime.Now:yyyy-MM-dd HH:mm:ss}.";
                    model.IsSuccess = true;
                }
                model.ShowResult = true;
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Clear()
        {
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
    }
}
