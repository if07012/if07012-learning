using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using basic_html_css.Models;
using Microsoft.AspNetCore.Mvc;

namespace basic_html_css.Controllers
{
    public class HomeController : Controller
    {        
        public HomeController()
        {            
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Task(basic_html_css.Models.ViewModels.TaskViewModel model)
        {
         
            model.Id = 4;
            return View(model);
        }
        [HttpGet]
        public IActionResult EditTask(int id)
        {
            
            var model = new basic_html_css.Models.ViewModels.TaskViewModel();
            

            
            return View("Task", model);
        }

        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult List()
        {

            return Json("");
        }
        public IActionResult Contact(int data)
        {
            ViewData["Message"] = data;

            return View("Contact", data);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
