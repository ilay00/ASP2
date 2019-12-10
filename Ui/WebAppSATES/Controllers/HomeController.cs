using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppSATES.Infrastructure;
using WebAppSATES.Interfaces;






namespace WebAppSATES.Controllers
{
    public class HomeController : Controller
    {
        private readonly IValuseServices _valueService;

        public HomeController(IValuseServices valueService)
        {
            _valueService = valueService;
        }

        [SimpleActionFilter]
        public async Task<IActionResult> Index()
        {
            var values = await _valueService.GetAsync();
            return View(values);

            //ViewData["Title"] = "Домашняя страница";
        }

        public HomeController() { }
        //public IActionResult Index() => View();
        public IActionResult blog() => View();
        public IActionResult cart() => View();
        public IActionResult checkout() => View();

        public IActionResult blogsingle() => View();
        public IActionResult contactus() => View();
        public IActionResult shop() => View();
        public IActionResult productdetails() => View();
        public IActionResult login() => View();
        public IActionResult Error404() => View();
        public IActionResult TestAction()
        {
            return new ViewResult();
            //return new JsonResult(new{Customer = "Иванов",Id = 15, Date = DateTime.Now});
            //return Json(new { Customer = "Иванов", Id = 15, Date = DateTime.Now });
            //return Redirect("http://www.yandex.ru");
            //return RedirectToAction("Index", "Employees");
        }
    }


    }
