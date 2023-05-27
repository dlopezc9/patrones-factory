namespace Factory.Services.Entities
{
    [Serializable]
    public class VehicleProperties
    {
        /// <summary>
        /// Informal name of the airplane.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Brand of the vehicle.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Hours of travel the vehicle.
        /// </summary>
        public int Hours { get; set; }

        /// <summary>
        /// Vehicle type.
        /// </summary>
        public string Type { get; set; }
    }
}
