using Factory.Services.Entities;
using Factory.Services.Interfaces;

namespace Factory.Services
{
    public class FactoryService : IFactoryService
    {
        private readonly IFactoryPattern _factoryPattern;

        private readonly IHangar _hangar; 

        public FactoryService(IFactoryPattern factoryPattern, IHangar hangar)
        {
            _factoryPattern = factoryPattern;
            _hangar = hangar;
        }

        public int CalculateTraveledDistance(VehicleProperties vehicleProperties)
        {
            Vehicle vehicle = _hangar.GetVehicle(vehicleProperties);
            return vehicle.DistanceTraveled();
        }

        public void CreateNewVehicle(VehicleProperties vehicleProperties)
        {
            _factoryPattern.CreateNewVehicle(vehicleProperties);
        }
    }
}
