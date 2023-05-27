using Factory.Services.Entities;
using Factory.Services.Interfaces;
using Factory.Services.Utils.Vehicles;

namespace Factory.Services
{
    /// <summary>
    /// Hangar class.
    /// </summary>
    public class Hangar : IHangar
    {
        private static Hangar _instance = null;

        /// <summary>
        /// List of vehicles of the hangar
        /// </summary>
        public List<Vehicle> Vehicles { get; set; }

        /// <summary>
        /// Id of the hangar.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Constructor for the hangar.
        /// </summary>
        /// <param name="id">Identifier for the hangar.</param>
        protected Hangar() 
        { 
            this.Vehicles = new List<Vehicle>();
        }

        public static Hangar Instance
        {
            get 
            { 
                if (_instance == null)
                    _instance = new Hangar();

                return _instance; 
            }
        }

        /// <summary>
        /// Add a new vehicle to the hangar.
        /// </summary>
        /// <param name="vehicle">Vehicle to be added to hangar.</param>
        public void ParkVehicle(Vehicle vehicle)
        {
            this.Vehicles.Add(vehicle);
        }

        /// <summary>
        /// Gets the specified vehicle.
        /// </summary>
        /// <param name="vehicleProperties">Properties of the vehicle to look for.</param>
        /// <returns>The vehicle.</returns>
        public Vehicle GetVehicle(VehicleProperties vehicleProperties)
        {
            switch (vehicleProperties.Type) 
            {
                case VehicleTypes.Airplane:
                    Vehicle airplane = this.Vehicles.Where(x => x.Name == vehicleProperties.Name && x.Brand == vehicleProperties.Brand).FirstOrDefault();
                    return airplane == null ? null : airplane;

                case VehicleTypes.Truck:
                    Vehicle truck = this.Vehicles.Where(x => x.Name == vehicleProperties.Name && x.Brand == vehicleProperties.Brand).FirstOrDefault();
                    return truck == null ? null : truck;

                default:
                    return null;
            }
        }

        /// <summary>
        /// Gets all the vehicles.
        /// </summary>
        /// <returns></returns>
        public List<Vehicle> GetVehicles()
        {
            return this.Vehicles;
        }
    }
}
