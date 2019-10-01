using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DessertShop.API.Models;
using DessertShop.API.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DessertShop.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDessertRepository _dessertRepository;

        public HomeController(IDessertRepository dessertRepository)
        {
            _dessertRepository = dessertRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Dessert Overview";

            var desserts = _dessertRepository.GetAllDessert().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel
            {
                Title = "Welcome to the Dessert Shop",
                Desserts = desserts.ToList()
            };


            return View(homeViewModel);
        }
    }
}
