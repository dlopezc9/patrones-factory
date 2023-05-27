using Factory.Services;
using Factory.Services.Entities;
using Factory.Services.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IFactoryPattern factory;

        private readonly IHangar hangar;

        public HomeController(IFactoryPattern factory, IHangar hangar) 
        { 
            this.factory = factory;
            this.hangar = hangar;
        }

        [HttpPost("AddVehicle")]
        public void AddNewVehicle(VehicleProperties vehicle)
        {
            factory.CreateNewVehicle(vehicle);
        }

        [HttpGet("GetHangarVehicles")]
        public IActionResult GetHangarVehicles()
        {
            var result = hangar.GetVehicles();

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }
    }
}
