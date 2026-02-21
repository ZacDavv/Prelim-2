public class ElectricBus : Vehicle
{
    private double batteryPercent;

    public double BatteryPercent
    {
        get => batteryPercent;
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Battery percentage must be between 0 and 100.");
            batteryPercent = value;
        }
    }

    public ElectricBus(string id, string name, double battery) : base(id, name)
    {
        BatteryPercent = battery;
    }

    public override double CalculateRange()
    {
        if (BatteryPercent < 5)
            throw new InvalidOperationException("Battery too low to calculate range.");
        return BatteryPercent * 2; // Example: each % gives 2 km
    }
}
