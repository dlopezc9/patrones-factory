using Factory.Logic.Utils;
using Factory.Logic.Utils.Airplane;

namespace Factory.Logic.Entities
{
    /// <summary>
    /// Vehicle type Vehicle.
    /// </summary>
    public class Airplane : Vehicle
    {

        /// <summary>
        /// Informal name of the airplane.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Brand of the airplane.
        /// </summary>
        public override string Brand { get; set; }

        /// <summary>
        /// Brand of the airplane.
        /// </summary>
        public override int Hours { get; set; }

        /// <summary>
        /// Constructor for airplane.
        /// </summary>
        /// <param name="brand">Brand for the airplane.</param>
        /// <param name="name">Name for the airplane.</param>
        public Airplane(string brand, string name, int hours) 
        { 
            this.Brand = brand;
            this.Name = name;
            this.Hours = hours;
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
                case AirplaneNames.Boeing:
                    return this.Hours * AirplaneSpeeds.Boeing + AirplaneExtra.Boeing;

                case AirplaneNames.Airbus:
                    return this.Hours * AirplaneSpeeds.Airbus + AirplaneExtra.Airbus;

                default:
                    return 0;
            }
        }
    }
}
