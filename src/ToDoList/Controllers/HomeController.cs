using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Model;
using ToDoList.Model.ToDoListViewModel;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ToDo()
        {
            return View();
        }

        public IActionResult EditToDo()
        {
            return View;
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
