public class Vehicle
{
    private string vehicleID;
    private string modelName;

    public string VehicleID
    {
        get => vehicleID;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("VehicleID cannot be empty.");
            vehicleID = value;
        }
    }

    public string ModelName
    {
        get => modelName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("ModelName cannot be empty.");
            modelName = value;
        }
    }

    public Vehicle(string id, string name)
    {
        VehicleID = id;
        ModelName = name;
    }

    public virtual double CalculateRange()
    {
        throw new NotImplementedException("Subclasses must override this method.");
    }
}
