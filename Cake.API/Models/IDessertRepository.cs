using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DessertShop.API.Models
{
    public interface IDessertRepository
    {
        IEnumerable<Dessert> GetAllDessert();
        Dessert GetDessertById(int dessertId);
    }
}
