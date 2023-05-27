using Factory.Services.Entities;

namespace Factory.Services.Interfaces
{
    public interface IFactoryService
    {
        public void CreateNewVehicle(VehicleProperties vehicleProperties);
        public int CalculateTraveledDistance(VehicleProperties vehicleProperties);
    }
}
