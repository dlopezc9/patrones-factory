using Factory.Logic;
using Factory.Logic.Entities;
using Factory.Logic.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    [ApiController]
    [Route("[home]")]
    public class HomeController : Controller
    {
        private readonly IFactory factory;

        private readonly IHangar hangar;

        public HomeController(IFactory factory, IHangar hangar) 
        { 
            this.factory = factory;
            this.hangar = hangar;
        }

        [HttpPost(Name = "AddHangar")]
        public void AddNewHangar(int id) 
        {
            hangar.CreateHangar(id);
        }

        [HttpPost(Name = "AddVehicle")]
        public void AddNewVehicle(VehicleProperties vehicle, int hangarId)
        {
            factory.CreateNewVehicle(vehicle, hangarId);
        }

        [HttpGet(Name = "GetHangarVehicles")]
        public void GetHangarVehicles(int id)
        {
            return;
        }
    }
}
