using System.Collections.Generic;
using Api.BoarService.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.BoarService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoarController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Boar> Get()
        {
            return new List<Boar>
            {
                new Boar() { Name = "Boar1", Weight = 105, Height = 196 },
                new Boar() { Name = "Boar2", Weight = 97, Height = 182 },
                new Boar() { Name = "Boar3", Weight = 78, Height = 164 }
            };
        }
    }
}