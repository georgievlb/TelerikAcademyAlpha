using Traveller.Enums;

namespace Traveller.Models.Vehicles.Contracts
{
    public interface IVehicle
    {
        int PassengerCapacity { get; }

        VehicleType Type { get; }

        decimal PricePerKilometer { get; }
    }
}