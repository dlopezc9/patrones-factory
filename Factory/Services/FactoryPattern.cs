using Factory.Services.Entities;
using Factory.Services.Interfaces;
using Factory.Services.Utils.Vehicles;

namespace Factory.Services
{
    /// <summary>
    /// The vehicle factory class.
    /// </summary>
    public class FactoryPattern : IFactoryPattern
    {

        /// <summary>
        /// ICellar interface
        /// </summary>
        private readonly IHangar _hangar;

        /// <summary>
        /// Constructor for Factory.
        /// </summary>
        /// <param name="vehicle">IVehicle interface.</param>
        public FactoryPattern(IHangar cellar) 
        {
            _hangar = cellar;
        }

        /// <summary>
        /// Creates a new vehicle.
        /// </summary>
        /// <param name="type">Type of vehicle to be created.</param>
        /// <param name="brand">Brand of the vehicle.</param>
        /// <param name="name">Name for the vehicle.</param>
        public void CreateNewVehicle(VehicleProperties vehicleProperties)
        {
            switch (vehicleProperties.Type)
            {
                case VehicleTypes.Airplane:
                    Airplane newAirplane = new Airplane(vehicleProperties.Brand, vehicleProperties.Name, vehicleProperties.Hours);
                    _hangar.ParkVehicle(newAirplane);
                    break;

                case VehicleTypes.Truck:
                    Truck newTruck = new Truck(vehicleProperties.Brand, vehicleProperties.Name, vehicleProperties.Hours);
                    _hangar.ParkVehicle(newTruck);
                    break;

                default:
                    break;
            }
        }
    }
}
