using System.Collections.Generic;
using Api.FoodService.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.FoodService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Food> Get()
        {
            return new List<Food>
            {
                new Food() { Name = "Apple", Category = "Fruits", Price = 6},
                new Food() { Name = "Carrot", Category = "Vegetables", Price = 2 },
                new Food() { Name = "Acorn", Category = "Other", Price = 8 },
                new Food() { Name = "Mushroom", Category = "Other", Price = 5 }
            };
        }
    }
}