using Microsoft.AspNetCore.Mvc;
using PizzaTask.Models;
using PizzaTask.Services;
using System;
using System.Collections.Generic;

namespace PizzaTask.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaService _service;

        public PizzaController(IPizzaService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            IEnumerable<Pizza> list = _service.GetAllPizzas();
            return View("Index", list);
        }
        [HttpGet]
        public IActionResult AddPizza()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPizza(Pizza pizza)
        {
            pizza.Id = Guid.NewGuid();
            _service.AddPizza(pizza);

            return RedirectToAction("Index");
        }
    }
}
