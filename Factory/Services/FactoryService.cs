using Factory.Services.Entities;
using Factory.Services.Interfaces;

namespace Factory.Services
{
   /// <summary>
   /// Service that calls the factory.
   /// </summary>
    public class FactoryService : IFactoryService
    {
        /// <summary>
        /// The factory interface.
        /// </summary>
        private readonly IFactoryPattern _factoryPattern;

        /// <summary>
        /// The hanger interface.
        /// </summary>
        private readonly IHangar _hangar;

        /// <summary>
        /// Constructor for the service.
        /// </summary>
        /// <param name="factoryPattern">The factory interface.</param>
        /// <param name="hangar">The hanger interface.</param>
        public FactoryService(IFactoryPattern factoryPattern, IHangar hangar)
        {
            _factoryPattern = factoryPattern;
            _hangar = hangar;
        }

        /// <summary>
        /// Gets a vehicle to calculate its travel distance.
        /// </summary>
        /// <param name="vehicleProperties"></param>
        /// <returns></returns>
        public int CalculateTraveledDistance(VehicleProperties vehicleProperties)
        {
            Vehicle vehicle = _hangar.GetVehicle(vehicleProperties);
            return vehicle.DistanceTraveled();
        }

        /// <summary>
        /// Create and add a new vehicle to the hangar.
        /// </summary>
        /// <param name="vehicleProperties"></param>
        public void CreateNewVehicle(VehicleProperties vehicleProperties)
        {
            _factoryPattern.CreateNewVehicle(vehicleProperties);
        }

        /// <summary>
        /// Create and add a new vehicle to the hangar.
        /// </summary>
        /// <param name="vehicleProperties"></param>
        public List<Vehicle> GetHangerVehicles()
        {
            return _hangar.GetAllVehicles();
        }
    }
}
