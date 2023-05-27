using Factory.Services;
using Factory.Services.Entities;
using Factory.Services.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    /// <summary>
    /// Main controller.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// Factory service.
        /// </summary>
        private readonly IFactoryService factoryService;

        /// <summary>
        /// Constructor for the controller.
        /// </summary>
        /// <param name="factoryService"></param>
        public HomeController(IFactoryService factoryService) 
        { 
            this.factoryService = factoryService;
        }

        /// <summary>
        /// Adds a new vehicle to the hangar.
        /// </summary>
        /// <param name="vehicle">The vehicle to add.</param>
        [HttpPost("AddVehicle")]
        public void AddNewVehicle(VehicleProperties vehicle)
        {
            factoryService.CreateNewVehicle(vehicle);
        }

        /// <summary>
        /// Gets all the hangar vehicles.
        /// </summary>
        /// <returns>A list with all the vehicles.</returns>
        [HttpGet("GetHangarVehicles")]
        public IActionResult GetHangarVehicles()
        {
            var result = factoryService.GetHangerVehicles();

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        /// <summary>
        /// Calculates the distance of the specified vehicle.
        /// </summary>
        /// <param name="vehicleProperties">The specified vehicle.</param>
        /// <returns>The distance it has traveled.</returns>
        [HttpPost("CalculateTraveledDistance")]
        public IActionResult CalculateTraveledDistance(VehicleProperties vehicleProperties)
        {
            int result = factoryService.CalculateTraveledDistance(vehicleProperties);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }
    }
}
