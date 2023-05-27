using Factory.Services.Entities;

namespace Factory.Services.Interfaces
{
    public interface IFactoryService
    {
        /// <summary>
        /// Gets a vehicle to calculate its travel distance.
        /// </summary>
        /// <param name="vehicleProperties"></param>
        /// <returns>The calculated distance.</returns>
        public int CalculateTraveledDistance(VehicleProperties vehicleProperties);

        /// <summary>
        /// Create and add a new vehicle to the hangar.
        /// </summary>
        /// <param name="vehicleProperties">The vehicle to be added.</param>
        public void CreateNewVehicle(VehicleProperties vehicleProperties);

        /// <summary>
        /// Create and add a new vehicle to the hangar.
        /// </summary>
        /// <param name="vehicleProperties"></param>
        public List<Vehicle> GetHangerVehicles();
    }
}
