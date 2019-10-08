using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using first_entity.Models;

namespace first_entity.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        //  here we can inject our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        // Render Route
        [HttpGet]
        [Route("")]
        public IActionResult Index()

        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();

            return View("Index", AllDishes);
        }

        // Render Route
        [HttpGet("Newdish")]
        public IActionResult Newdish()
        {

            return View("Newdish");
        }

        // Process Route
        [HttpPost("Createdish")]
        public IActionResult Createdish(Dish newDish)
        {
            dbContext.Add(newDish);

            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        // Render Route
        [HttpGet("Viewdish/{DishId}")]
        public IActionResult Viewdish(int DishId)
        {
            // Find me the Dish in the database where its DishId == DishId
            Dish oneDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == DishId);
            // int oneDish = DishId;
            return View("ViewDish", oneDish);
        }


        // Process Route
        [HttpGet("Delete/{dishId}")]
        public IActionResult Delete(int dishId)
        {
            Dish deleteDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);

            dbContext.Remove(deleteDish);

            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }


        // Render Route
        [HttpGet("Editdish/{DishId}")]
        public IActionResult Editdish(int DishId)
        {
            // Find me the Dish in the database where its DishId == DishId
            Dish oneDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == DishId);
            // int oneDish = DishId;
            return View("Editdish", oneDish);
        }


        // Process Route
        [HttpGet("Moddish/{DishId}")]
        public IActionResult Moddish(int DishId)
        {
            // Find me the Dish in the database where its DishId == DishId
            Dish ModDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == DishId);

            ModDish.Name = ModDish.Name;
            ModDish.Chef = ModDish.Chef;
            ModDish.Tastiness = ModDish.Tastiness;
            ModDish.Calories = ModDish.Calories;
            ModDish.Description = ModDish.Description;
            ModDish.UpdatedAt = DateTime.Now;
            dbContext.SaveChanges();


            // int oneDish = DishId;
            return View("Index");
        }








    }

}
