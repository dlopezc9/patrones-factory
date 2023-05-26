using Factory.Logic.Interfaces;

namespace Factory.Logic
{
    /// <summary>
    /// Hangar class.
    /// </summary>
    public class Hangar : IHangar
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
        /// Constructor for the hangar.
        /// </summary>
        /// <param name="id">Identifier for the hangar.</param>
        public Hangar(int id) 
        { 
            this.Vehicles = new List<Vehicle>();
            this.Id = id;
        }

        /// <summary>
        /// Add a new vehicle to the hangar.
        /// </summary>
        /// <param name="vehicle">Vehicle to be added to hangar.</param>
        public void ParkVehicle(Vehicle vehicle)
        {
            this.Vehicles.Add(vehicle);
        }
    }
}
