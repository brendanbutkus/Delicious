using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Delicious.Models;
using Microsoft.EntityFrameworkCore;


namespace Delicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.AllDishes = _context.Dishes.OrderBy(a=>a.Name).ToList();
            return View();
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }


        [HttpPost("addDish")]
        public IActionResult addDish(Dishes newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else{
                return View("Index");
            }
        }

        [HttpGet("dish/{dishId}")]

        public IActionResult oneDish(int dishId)
        {
            Dishes oneDish = _context.Dishes.FirstOrDefault(x => x.DishId == dishId);
            return View("oneDish", oneDish);
        }

        [HttpGet("delete/{dishId}")]

        public IActionResult deleteOne(int dishId)
        {
            Dishes oneDish = _context.Dishes.SingleOrDefault(x => x.DishId == dishId);
            _context.Dishes.Remove(oneDish);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{dishId}")]

        public IActionResult Edit(int dishId)
        {
            Dishes oneDish = _context.Dishes.FirstOrDefault(x => x.DishId == dishId);
            return View(oneDish);
        }

        [HttpPost("updateDish/{dishId}")]
        public IActionResult Update(int dishId, Dishes dishToEdit)
        {
            if(ModelState.IsValid)
            {
            Dishes original = _context.Dishes.FirstOrDefault(x => x.DishId == dishId);
            original.Name = dishToEdit.Name;
            original.Chef = dishToEdit.Chef;
            original.Tastiness = dishToEdit.Tastiness;
            original.Calories = dishToEdit.Calories;
            original.Description = dishToEdit.Description;
            original.UpdatedAt = dishToEdit.UpdatedAt;
            _context.SaveChanges();
            return RedirectToAction("Index");
            }
            else{
                return View("Edit", dishToEdit);
            }
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
    }
}
