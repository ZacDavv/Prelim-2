public class GasPoweredVan : Vehicle
{
    private double fuelLevel;

    public double FuelLevel
    {
        get => fuelLevel;
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Fuel level must be between 0 and 100.");
            fuelLevel = value;
        }
    }

    public GasPoweredVan(string id, string name, double fuel) : base(id, name)
    {
        FuelLevel = fuel;
    }

    public override double CalculateRange()
    {
        if (FuelLevel < 5)
            throw new InvalidOperationException("Fuel too low to calculate range.");
        return FuelLevel * 1.5; // Example: each % gives 1.5 km
    }
}
