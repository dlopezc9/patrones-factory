namespace Factory.Logic.Interfaces
{
    public interface IVehicle
    {
        /// <summary>
        /// Calculates the distance traveled for trucks.
        /// </summary>
        /// <param name="hours">Amount of hours traveled.</param>
        /// <param name="type">Type of truck traveled.</param>
        /// <returns>Calculation of distance traveled.</returns>
        public abstract int DistanceTraveled();
    }
}
