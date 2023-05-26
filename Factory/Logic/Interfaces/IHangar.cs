namespace Factory.Logic.Interfaces
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
    }
}
