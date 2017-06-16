using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestGit.Models;

namespace TestGit.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string firstVelue, string secondVelue, Selection action)
        {
            double a = 20;
            double b = 10;
            try
            {
                a = double.Parse(firstVelue);
                b = double.Parse(secondVelue);
                switch (action)
                {
                    case Selection.Sum:
                        ViewBag.Res = $"Результат равен - {new Calc().Sum(a, b)}";
                        break;
                    case Selection.Sub:
                        ViewBag.Res = $"Результат равен - {new Calc().Sub(a, b)}";
                        break;
                    case Selection.Mult:
                        ViewBag.Res = $"Результат равен - {new Calc().Mult(a, b)}";
                        break;
                    case Selection.Div:
                        if (double.IsInfinity(new Calc().Div(a, b)))
                        {
                            ViewBag.Res = "На ноль могут делить только индусы! Только они понимают что такое БЕСКОНЕЧНОСТЬ! :)";
                            break;
                        }
                            ViewBag.Res = $"Результат равен - {new Calc().Div(a, b)}";
                            break;
                        
                }
            }
            catch (Exception)
            {
                ViewBag.Res = "Вы ввели что то не то...";
            }
            
            
            return PartialView("Result");
        }
    }

    public enum Selection
    {
        None = 0,
        Sum = 1,
        Sub = 2,
        Mult = 3,
        Div = 4
    }


}
