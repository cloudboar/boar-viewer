using System.Collections.Generic;
using Api.BoarService.Controllers;
using NUnit.Framework;

namespace Boar.Viewer.Tests
{

    public class TestsApiBoarService
    {
        [Test]
        public void Get_ShouldReturnAllBoars()
        {
            var controller = new  BoarController();

            var result = controller.Get() as List<Api.BoarService.Models.Boar>;
            Assert.AreEqual(3, result?.Count);
        }
    }
}