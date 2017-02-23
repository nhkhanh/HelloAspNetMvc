using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sum(int a, int b)
        {
            CalculatorModels model = new CalculatorModels() { a = a, b = b };
            model.Sum();
            return View(model);
        }
    }
}