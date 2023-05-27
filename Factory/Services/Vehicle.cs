using Factory.Services.Interfaces;

namespace Factory.Services
{
    public abstract class Vehicle : IVehicle
    {
        /// <summary>
        /// Informal name of the airplane.
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// Brand of the vehicle.
        /// </summary>
        public abstract string Brand { get; set; }

        /// <summary>
        /// Hours of travel the vehicle.
        /// </summary>
        public abstract int Hours { get; set; }

        /// <summary>
        /// Calculates the distance traveled for the vehicle.
        /// </summary>
        /// <param name="hours">Amount of hours traveled.</param>
        /// <param name="type">Type of vehicle traveled.</param>
        /// <returns>Calculation of distance traveled.</returns>
        public abstract int DistanceTraveled();
    }
}
