using System.Runtime.CompilerServices;

using Factory.Logic.Utils.Truck;

namespace Factory.Logic.Entities
{
    /// <summary>
    /// Vehicle type Vehicle.
    /// </summary>
    public class Truck : Vehicle
    {
        /// <summary>
        /// Informal name of the truck.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Brand of the truck.
        /// </summary>
        public override string Brand { get; set; }

        /// <summary>
        /// Amount of wheels of the truck.
        /// </summary>
        public int Wheels { get; set; }

        /// <summary>
        /// Traveled hours of the vehicle.
        /// </summary>
        public int Hours { get; set; }

        /// <summary>
        /// Constructor for airplane.
        /// </summary>
        /// <param name="brand">Brand for the airplane.</param>
        /// <param name="name">Name for the airplane.</param>
        public Truck(string brand, string name, int hours)
        {
            this.Brand = brand;
            this.Name = name;
            this.Hours = hours;

            switch (Brand) 
            {
                case TruckNames.Nissan:
                    this.Wheels = 8;
                    break;

                case TruckNames.Toyota: 
                    this.Wheels = 6;
                    break;
            }
        }
        /// <summary>
        /// Calculates the distance traveled for trucks.
        /// </summary>
        /// <param name="hours">Amount of hours traveled.</param>
        /// <param name="type">Type of truck traveled.</param>
        /// <returns>Calculation of distance traveled.</returns>
        public override int DistanceTraveled()
        {
            switch (this.Brand)
            {
                case TruckNames.Nissan:
                    return this.Hours * TruckSpeeds.Nissan;

                case TruckNames.Toyota:
                    return this.Hours * TruckSpeeds.Toyota;

                default:
                    return 0;
            }
        }
    }
}
