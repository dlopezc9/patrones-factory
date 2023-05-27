using Factory.Services;
using Factory.Services.Entities;
using Factory.Services.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    [ApiController]
    [Route("[home]")]
    public class HomeController : Controller
    {
        private readonly IFactoryPattern factory;

        private readonly IHangar hangar;

        public HomeController(IFactoryPattern factory, IHangar hangar) 
        { 
            this.factory = factory;
            this.hangar = hangar;
        }

        [HttpPost(Name = "AddVehicle")]
        public void AddNewVehicle(VehicleProperties vehicle)
        {
            factory.CreateNewVehicle(vehicle);
        }

        [HttpGet(Name = "GetHangarVehicles")]
        public void GetHangarVehicles(VehicleProperties vehicle)
        {
            hangar.GetVehicle(vehicle);
        }
    }
}
