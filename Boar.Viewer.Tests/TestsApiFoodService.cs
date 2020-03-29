using System.Collections.Generic;
using Api.FoodService.Controllers;
using Api.FoodService.Models;
using NUnit.Framework;

namespace Boar.Viewer.Tests
{
    public class TestsApiFoodService
    {
        [Test]
        public void Get_ShouldReturnAllFood()
        {
            var controller = new FoodController();

            var result = controller.Get() as List<Food>;
            Assert.AreEqual(4, result?.Count);
        }
    }
}