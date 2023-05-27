using Factory.Services.Entities;

namespace Factory.Services.Interfaces
{
    public interface IHangar
    {
        /// <summary>
        /// List of vehicles of the hangar
        /// </summary>
        public List<Vehicle> Vehicles { get; set; }

        /// <summary>
        /// Id of the hangar.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Add a new vehicle to the hangar.
        /// </summary>
        /// <param name="vehicle">Vehicle to be added to hangar.</param>
        public void ParkVehicle(Vehicle vehicle);

        /// <summary>
        /// Looks for specified vehicle in the hangar.
        /// </summary>
        /// <param name="vehicleProperties">Properties of the vehicle to look for.</param>
        /// <returns>The vehicle.</returns>
        public Vehicle GetVehicle(VehicleProperties vehicleProperties);

        /// <summary>
        /// Method to get all the parked vehicles in the hangar.
        /// </summary>
        /// <returns>List with all the vehicles.</returns>
        public List<Vehicle> GetAllVehicles();
    }
}
