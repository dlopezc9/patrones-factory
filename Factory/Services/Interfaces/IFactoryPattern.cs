using Factory.Services.Entities;

namespace Factory.Services.Interfaces
{
    public interface IFactoryPattern
    {
        /// <summary>
        /// Creates a new vehicle.
        /// </summary>
        /// <param name="type">Type of vehicle to be created.</param>
        /// <param name="brand">Brand of the vehicle.</param>
        /// <param name="name">Name for the vehicle.</param>
        public void CreateNewVehicle(VehicleProperties vehicleProperties);
    }
}
