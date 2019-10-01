using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DessertShop.API.Models;

namespace DessertShop.API.ViewModels
{
    public class HomeViewModel
    {

        public string Title { get; set; }
        public List<Dessert> Desserts { get; set; }

    }
}
